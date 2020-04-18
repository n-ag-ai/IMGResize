using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;

namespace IMGResizer
{
    public class WaitDialog2 : System.Windows.Forms.Form
    {
        private bool bAborting = false;     // 中止フラグ
        private bool bShowing = false;      // ダイアログ表示中フラグ

        public System.Windows.Forms.Label main_label;
        public System.Windows.Forms.Label sub_label;
        private System.Windows.Forms.Button cancel_button;

        /// <summary>
        /// 必要なデザイナ変数です。
        /// </summary>
        private System.ComponentModel.Container components = null;

        public WaitDialog()
        {
            //
            // Windows フォーム デザイナ サポートに必要です。
            //
            InitializeComponent();

            //
            // TODO: InitializeComponent 呼び出しの後に、コンストラクタ コードを追加してください。
            //
        }

        /// <summary>
        /// 使用されているリソースに後処理を実行します。
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナで生成されたコード 
        /// <summary>
        /// デザイナ サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディタで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.cancel_button = new System.Windows.Forms.Button();
            this.main_label = new System.Windows.Forms.Label();
            this.sub_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cancel_button
            // 
            this.cancel_button.Location = new System.Drawing.Point(97, 116);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(75, 23);
            this.cancel_button.TabIndex = 0;
            this.cancel_button.Text = "キャンセル";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // main_label
            // 
            this.main_label.Location = new System.Drawing.Point(12, 18);
            this.main_label.Name = "main_label";
            this.main_label.Size = new System.Drawing.Size(250, 22);
            this.main_label.TabIndex = 1;
            this.main_label.Text = "メインメッセージ";
            this.main_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sub_label
            // 
            this.sub_label.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.sub_label.Location = new System.Drawing.Point(12, 61);
            this.sub_label.Name = "sub_label";
            this.sub_label.Size = new System.Drawing.Size(250, 22);
            this.sub_label.TabIndex = 2;
            this.sub_label.Text = "サブメッセージ";
            this.sub_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WaitDialog2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 151);
            this.Controls.Add(this.sub_label);
            this.Controls.Add(this.main_label);
            this.Controls.Add(this.cancel_button);
            this.MaximumSize = new System.Drawing.Size(290, 190);
            this.MinimumSize = new System.Drawing.Size(290, 190);
            this.Name = "WaitDialog2";
            this.Text = "WaitDialog2";
            this.ResumeLayout(false);

            }
        #endregion

        /// <summary>
        /// ShowDialogメソッドのシャドウ（WaitDialogクラスでは、ShowDialogメソッドは使用不可）
        /// </summary>
        public new DialogResult ShowDialog()
        {
            Debug.Assert(false,
              "WaitDialogクラスはShowDialogメソッドを利用できません。\n" +
              "Showメソッドを使ってモードレス・ダイアログを構築してください。");
            return DialogResult.Abort;
        }

        /// <summary>
        /// Showメソッドのシャドウ（シャドウ＝new修飾子）
        /// </summary>
        public new void Show()
        {
            // 変数の初期化
            this.DialogResult = DialogResult.OK;
            this.bAborting = false;

            base.Show();
            this.bShowing = true;
        }

        /// <summary>
        /// Closeメソッドのシャドウ
        /// </summary>
        public new void Close()
        {
            this.bShowing = false;
            base.Close();
        }

        /// <summary>
        /// キャンセル・ボタンが押されたときの処理
        /// </summary>
        /// <remarks>処理を途中でキャンセル（中断）する。</remarks>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            Abort();    // 中止処理
        }

        /// <summary>
        /// 中止（キャンセル）処理
        /// </summary>
        private void Abort()
        {
            this.bAborting = true;
            this.DialogResult = DialogResult.Abort;
        }

        /// <summary>
        /// ダイアログが閉じられるときの処理
        /// </summary>
        /// <remarks>
        /// 右上の［閉じる］ボタンが押された場合には、
        /// ［キャンセル］ボタンと同じように、処理を途中でキャンセル（中断）する。
        /// </remarks>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WaitDialog_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (bShowing == true)
            {
                // ダイアログ表示中なので中止（キャンセル）処理を実行
                Abort();
                // まだダイアログは閉じない
                e.Cancel = true;
            }
            else
            {
                // フォームは閉じられるところので素直に閉じる
                e.Cancel = false;
            }
        }

        /// **************************************************************

        /// <summary>
        /// 処理がキャンセル（中止）されているかどうかを示す値を取得する。
        /// キャンセルされた場合はtrue。それ以外はfalse。
        /// </summary>
        public bool IsAborting
        {
            get
            {
                return this.bAborting;
            }
        }

        /// <summary>
        /// メイン・メッセージのテキストを設定する。
        /// </summary>
        /// <remarks>
        /// 処理の概要を表示する。
        /// 例えば、ファイルの転送を行っているなら、「ファイルを転送しています……」のように表示する。
        /// </remarks>
        public string MainMsg
        {
            set
            {
                this.labelMainMsg.Text = value;
            }
        }

        /// <summary>
        /// サブ・メッセージのテキストを設定する。
        /// </summary>
        /// <remarks>
        /// 詳細な処理内容を表示する。
        /// 例えば、ファイル転送なら、転送中の個別のファイル名（「readme.htm」「contents.htm」など）を表示する。
        /// </remarks>
        public string subMsg
        {
            set
            {
                this.labelSubMsg.Text = value;
            }
        }

        /// <summary>
        /// 進行状況メッセージのテキストを設定する。
        /// </summary>
        /// <remarks>
        /// 処理の進行状況として、「何件分の何件が終わったのか」「全体の何％が終わったのか」などを表示する。
        /// </remarks>
        public string ProgressMsg
        {
            set
            {
                this.labelProgress.Text = value;
            }
        }

        /// <summary>
        /// 進行状況メーターの現在位置を設定する。
        /// </summary>
        /// <remarks>
        /// 例えば、処理に200の工数があった場合、現在その200の工数の中のどの位置にいるかを示す値。
        /// 既定値は「0」。
        /// </remarks>
        public int ProgressValue
        {
            set
            {
                this.progBarMeter.Value = value;
            }
        }

        /// <summary>
        /// 進行状況メーターの範囲の最大値を設定する。
        /// </summary>
        /// <remarks>
        /// 処理に200の工数があるなら「200」になる。
        /// 既定値は「100」。
        /// </remarks>
        public int ProgressMax
        {
            set
            {
                this.progBarMeter.Maximum = value;
            }
        }

        /// <summary>
        /// 進行状況メーターの範囲の最小値を設定する。
        /// </summary>
        /// <remarks>
        /// 既定値は「0」。
        /// </remarks>
        public int ProgressMin
        {
            set
            {
                this.progBarMeter.Minimum = value;
            }
        }

        /// <summary>
        /// PerformStepメソッドを呼び出したときに、進行状況メーターの現在位置を進める量（ProgressValueの増分値）を設定する。
        /// </summary>
        /// <remarks>
        /// 処理工数が200で、5つの工数が終わった段階で進行状況メーターを更新したい場合は「5」にする。
        /// 既定値は「10」。
        /// </remarks>
        public int ProgressStep
        {
            set
            {
                this.progBarMeter.Step = value;
            }
        }

        /// <summary>
        /// 進行状況メーターの現在位置（ProgressValue）をProgressStepプロパティの量だけ進める。
        /// </summary>
        public void PerformStep()
        {
            this.progBarMeter.PerformStep();
        }
    }
}