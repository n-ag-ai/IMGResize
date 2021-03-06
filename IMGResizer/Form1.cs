﻿using System;
using System.Collections;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace IMGResizer
{
    public partial class Form1 : Form
    {
        private ArrayList imageList = new ArrayList();

        public Form1()
        {
            InitializeComponent();
        }

        private void start_button_Click(object sender, EventArgs e)
        {
            int size = ParseSize();
            int side = ParseSide();
            if (!DataCheck(size))
            {
                return;
            }

            WaitDialog waitDialog = new WaitDialog();
            waitDialog.Owner = this;
            waitDialog.MainMsg = "処理中";
            waitDialog.ProgressMax = imageList.Count;
            waitDialog.ProgressMin = 0;
            waitDialog.ProgressStep = 1;
            waitDialog.ProgressValue = 0;
            this.Enabled = false;
            waitDialog.Show();
            int iCount = 0;
            foreach (String imagePath in imageList)
            {
                if (waitDialog.IsAborting == true)
                {
                    break;
                }
                waitDialog.ProgressMsg =  ((int)(iCount * 100 / imageList.Count)).ToString() + "%　" + "（" + iCount.ToString() + " / " + imageList.Count+ " 件）";
                Application.DoEvents();

                ImageResize imageResize = new ImageResize();
                imageResize.SetAfterSize(size);
                imageResize.SetBaseSide(side);
                imageResize.SetInputImagePath(imagePath);

                Bitmap bitmap = imageResize.StartResize();
                if (bitmap == null)
                {
                    Message("問題が発生しました。");
                    Application.DoEvents();
                    Thread.Sleep(100);
                    this.Activate();
                    waitDialog.Close();
                    this.Enabled = true;

                    imageList.Clear();
                    return;
                }
                bitmap.Save(SaveDirectory(imagePath));
                bitmap.Dispose();

                iCount++;
                waitDialog.PerformStep();
            }
            if (waitDialog.DialogResult == DialogResult.Abort)
            {
                waitDialog.SubMsg = "処理を中断しました。";
            }
            else
            {
                waitDialog.SubMsg = "処理を完了しました。";
                waitDialog.ProgressMsg = "100%　（" + imageList.Count + " / " + imageList.Count + " 件）";
            }

            Application.DoEvents();
            Thread.Sleep(100);
            this.Activate();
            waitDialog.Close();
            this.Enabled = true;

            imageList.Clear();
        }

        private string SaveDirectory(string imagePath)
        {
            string imageName = Path.GetFileName(imagePath);
            string imageDir = Path.GetDirectoryName(imagePath);
            string newDir = imageDir + "\\Resize";
            if (!(Directory.Exists(newDir)))
            {
                Directory.CreateDirectory(newDir);
            }
            return newDir + "\\" + imageName;
        }

        private Boolean DataCheck(int size)
        {
            if (size == -1)
            {
                return false;
            }
            else if (size == 0)
            {
                Message("変換後サイズに\"0\"が設定されています。\r\n\"0\"は設定できません");
                return false;
            }
            return true;
        }

        private int ParseSide()
        {
            if (width_radioButton.Checked)
            {
                return 1;
            }
            else if (heigh_radioButton.Checked)
            {
                return 2;
            }
            return 0;
        }

        private int ParseSize()
        {
            try
            {
                int size = int.Parse(resize_textBox.Text);
                if (size <= 0 || size > 10000)
                {
                    Message("変換後サイズに入力できる値は1～10000です");
                    return -1;
                }
                return size;
            }
            catch (FormatException)
            {
                Message("変換後サイズに数値以外が入力されています。");
                return -1;
            }
        }

        private void Message(String msg)
        {
            MessageBox.Show(msg, "入力値エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void OnDrop(object sender, DragEventArgs e)
        {
            textBox1.Text = "";
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            for (int i = 0; i < files.Length; i++)
            {
                if (File.Exists(files[i]))
                {
                    AddList(files[i]);
                }
                else if (Directory.Exists(files[i]))
                {
                    string[] files2 = null;
                    if (top_radioButton.Checked)
                    {
                        files2 = System.IO.Directory.GetFiles(files[i], "*", System.IO.SearchOption.TopDirectoryOnly);
                    }
                    else if(all_radioButton.Checked)
                    {
                        files2 = System.IO.Directory.GetFiles(files[i], "*", System.IO.SearchOption.AllDirectories);
                    }
                    
                    for(int j = 0; j < files2.Length; j++)
                    {
                        AddList(files2[j]);
                    }
                }
            }
        }

        private void AddList(String file) 
        {
            try
            {
                System.Drawing.Image image = System.Drawing.Image.FromFile(file);
                if (image.RawFormat.Equals(System.Drawing.Imaging.ImageFormat.Jpeg) ||
                    image.RawFormat.Equals(System.Drawing.Imaging.ImageFormat.Png))
                {
                    imageList.Add(file);
                    textBox1.Text += file + "\r\n";
                }
                image.Dispose();
            } catch (System.OutOfMemoryException){}
        }

        private void OnEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.All;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
    }
}
