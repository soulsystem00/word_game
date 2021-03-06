﻿namespace 단어장
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txt_word = new System.Windows.Forms.Label();
            this.txt_mean = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_submit = new System.Windows.Forms.Button();
            this.list_words = new System.Windows.Forms.ListView();
            this.단어 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.뜻 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txt_result = new System.Windows.Forms.Label();
            this.txt_Sword = new System.Windows.Forms.TextBox();
            this.txt_Smean = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_listdel = new System.Windows.Forms.Button();
            this.btn_extention = new System.Windows.Forms.Button();
            this.btn_redution = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_cornum = new System.Windows.Forms.Label();
            this.txt_incornum = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_wordcnt = new System.Windows.Forms.Label();
            this.list_Wword = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_WwT = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_mean_visible = new System.Windows.Forms.Button();
            this.btn_start_test = new System.Windows.Forms.Button();
            this.txt_Wword_cnt = new System.Windows.Forms.Label();
            this.btn_Wword_del = new System.Windows.Forms.Button();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_copy = new System.Windows.Forms.Button();
            this.CB_Hardmode = new System.Windows.Forms.CheckBox();
            this.tp_Hard_Mode_discription = new System.Windows.Forms.ToolTip(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_word
            // 
            this.txt_word.AutoSize = true;
            this.txt_word.Font = new System.Drawing.Font("굴림", 40F, System.Drawing.FontStyle.Bold);
            this.txt_word.Location = new System.Drawing.Point(94, 24);
            this.txt_word.Name = "txt_word";
            this.txt_word.Size = new System.Drawing.Size(185, 54);
            this.txt_word.TabIndex = 0;
            this.txt_word.Text = "단어장";
            // 
            // txt_mean
            // 
            this.txt_mean.Font = new System.Drawing.Font("굴림", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_mean.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.txt_mean.Location = new System.Drawing.Point(103, 80);
            this.txt_mean.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_mean.Name = "txt_mean";
            this.txt_mean.Size = new System.Drawing.Size(200, 38);
            this.txt_mean.TabIndex = 1;
            this.txt_mean.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_mean_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(45, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "뜻";
            // 
            // btn_submit
            // 
            this.btn_submit.Font = new System.Drawing.Font("굴림", 20F);
            this.btn_submit.Location = new System.Drawing.Point(309, 80);
            this.btn_submit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(76, 38);
            this.btn_submit.TabIndex = 3;
            this.btn_submit.Text = "제출";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // list_words
            // 
            this.list_words.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.단어,
            this.뜻});
            this.list_words.HideSelection = false;
            this.list_words.Location = new System.Drawing.Point(542, 153);
            this.list_words.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.list_words.Name = "list_words";
            this.list_words.Size = new System.Drawing.Size(283, 126);
            this.list_words.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.list_words.TabIndex = 4;
            this.list_words.UseCompatibleStateImageBehavior = false;
            this.list_words.View = System.Windows.Forms.View.Details;
            // 
            // 단어
            // 
            this.단어.Text = "단어";
            this.단어.Width = 120;
            // 
            // 뜻
            // 
            this.뜻.Text = "뜻";
            this.뜻.Width = 100;
            // 
            // txt_result
            // 
            this.txt_result.AutoSize = true;
            this.txt_result.Location = new System.Drawing.Point(101, 162);
            this.txt_result.Name = "txt_result";
            this.txt_result.Size = new System.Drawing.Size(32, 12);
            this.txt_result.TabIndex = 5;
            this.txt_result.Text = "hello";
            // 
            // txt_Sword
            // 
            this.txt_Sword.Font = new System.Drawing.Font("굴림", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_Sword.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.txt_Sword.Location = new System.Drawing.Point(103, 244);
            this.txt_Sword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Sword.Name = "txt_Sword";
            this.txt_Sword.Size = new System.Drawing.Size(200, 38);
            this.txt_Sword.TabIndex = 6;
            // 
            // txt_Smean
            // 
            this.txt_Smean.Font = new System.Drawing.Font("굴림", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_Smean.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.txt_Smean.Location = new System.Drawing.Point(103, 287);
            this.txt_Smean.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Smean.Name = "txt_Smean";
            this.txt_Smean.Size = new System.Drawing.Size(200, 38);
            this.txt_Smean.TabIndex = 7;
            this.txt_Smean.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Smean_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(18, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 27);
            this.label1.TabIndex = 8;
            this.label1.Text = "단어";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(45, 290);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 27);
            this.label3.TabIndex = 9;
            this.label3.Text = "뜻";
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("굴림", 20F);
            this.btn_save.Location = new System.Drawing.Point(309, 244);
            this.btn_save.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(76, 81);
            this.btn_save.TabIndex = 10;
            this.btn_save.Text = "저장";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_listdel
            // 
            this.btn_listdel.Location = new System.Drawing.Point(829, 229);
            this.btn_listdel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_listdel.Name = "btn_listdel";
            this.btn_listdel.Size = new System.Drawing.Size(145, 24);
            this.btn_listdel.TabIndex = 11;
            this.btn_listdel.Text = "삭제";
            this.btn_listdel.UseVisualStyleBackColor = true;
            this.btn_listdel.Click += new System.EventHandler(this.btn_listdel_Click);
            // 
            // btn_extention
            // 
            this.btn_extention.Location = new System.Drawing.Point(319, 373);
            this.btn_extention.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_extention.Name = "btn_extention";
            this.btn_extention.Size = new System.Drawing.Size(66, 29);
            this.btn_extention.TabIndex = 12;
            this.btn_extention.Text = "보이기";
            this.btn_extention.UseVisualStyleBackColor = true;
            this.btn_extention.Click += new System.EventHandler(this.btn_extention_Click);
            // 
            // btn_redution
            // 
            this.btn_redution.Location = new System.Drawing.Point(319, 374);
            this.btn_redution.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_redution.Name = "btn_redution";
            this.btn_redution.Size = new System.Drawing.Size(66, 29);
            this.btn_redution.TabIndex = 13;
            this.btn_redution.Text = "숨기기";
            this.btn_redution.UseVisualStyleBackColor = true;
            this.btn_redution.Click += new System.EventHandler(this.btn_redution_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(266, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 12);
            this.label4.TabIndex = 14;
            this.label4.Text = "맞춘개수 :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(266, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 15;
            this.label5.Text = "틀린개수 : ";
            // 
            // txt_cornum
            // 
            this.txt_cornum.AutoSize = true;
            this.txt_cornum.Location = new System.Drawing.Point(339, 136);
            this.txt_cornum.Name = "txt_cornum";
            this.txt_cornum.Size = new System.Drawing.Size(11, 12);
            this.txt_cornum.TabIndex = 16;
            this.txt_cornum.Text = "0";
            // 
            // txt_incornum
            // 
            this.txt_incornum.AutoSize = true;
            this.txt_incornum.Location = new System.Drawing.Point(339, 162);
            this.txt_incornum.Name = "txt_incornum";
            this.txt_incornum.Size = new System.Drawing.Size(11, 12);
            this.txt_incornum.TabIndex = 17;
            this.txt_incornum.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(539, 456);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 12);
            this.label6.TabIndex = 18;
            this.label6.Text = "단어갯수 :";
            this.label6.Visible = false;
            // 
            // txt_wordcnt
            // 
            this.txt_wordcnt.AutoSize = true;
            this.txt_wordcnt.Location = new System.Drawing.Point(629, 139);
            this.txt_wordcnt.Name = "txt_wordcnt";
            this.txt_wordcnt.Size = new System.Drawing.Size(11, 12);
            this.txt_wordcnt.TabIndex = 19;
            this.txt_wordcnt.Text = "0";
            // 
            // list_Wword
            // 
            this.list_Wword.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.list_Wword.HideSelection = false;
            this.list_Wword.Location = new System.Drawing.Point(542, 311);
            this.list_Wword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.list_Wword.Name = "list_Wword";
            this.list_Wword.Size = new System.Drawing.Size(283, 131);
            this.list_Wword.TabIndex = 20;
            this.list_Wword.UseCompatibleStateImageBehavior = false;
            this.list_Wword.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "단어";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "뜻";
            this.columnHeader2.Width = 100;
            // 
            // btn_WwT
            // 
            this.btn_WwT.Location = new System.Drawing.Point(829, 418);
            this.btn_WwT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_WwT.Name = "btn_WwT";
            this.btn_WwT.Size = new System.Drawing.Size(145, 23);
            this.btn_WwT.TabIndex = 21;
            this.btn_WwT.Text = "틀린단어 테스트 시작";
            this.btn_WwT.UseVisualStyleBackColor = true;
            this.btn_WwT.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(539, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 12);
            this.label7.TabIndex = 22;
            this.label7.Text = "저장된 단어 :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(539, 297);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 12);
            this.label8.TabIndex = 23;
            this.label8.Text = "틀린단어 :";
            // 
            // btn_mean_visible
            // 
            this.btn_mean_visible.Location = new System.Drawing.Point(829, 393);
            this.btn_mean_visible.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_mean_visible.Name = "btn_mean_visible";
            this.btn_mean_visible.Size = new System.Drawing.Size(145, 23);
            this.btn_mean_visible.TabIndex = 24;
            this.btn_mean_visible.Text = "단어 뜻 숨기기";
            this.btn_mean_visible.UseVisualStyleBackColor = true;
            this.btn_mean_visible.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btn_start_test
            // 
            this.btn_start_test.Location = new System.Drawing.Point(829, 254);
            this.btn_start_test.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_start_test.Name = "btn_start_test";
            this.btn_start_test.Size = new System.Drawing.Size(145, 24);
            this.btn_start_test.TabIndex = 25;
            this.btn_start_test.Text = "테스트 시작";
            this.btn_start_test.UseVisualStyleBackColor = true;
            this.btn_start_test.Click += new System.EventHandler(this.btn_start_test_Click);
            // 
            // txt_Wword_cnt
            // 
            this.txt_Wword_cnt.AutoSize = true;
            this.txt_Wword_cnt.Location = new System.Drawing.Point(612, 297);
            this.txt_Wword_cnt.Name = "txt_Wword_cnt";
            this.txt_Wword_cnt.Size = new System.Drawing.Size(38, 12);
            this.txt_Wword_cnt.TabIndex = 26;
            this.txt_Wword_cnt.Text = "label9";
            // 
            // btn_Wword_del
            // 
            this.btn_Wword_del.Location = new System.Drawing.Point(829, 369);
            this.btn_Wword_del.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Wword_del.Name = "btn_Wword_del";
            this.btn_Wword_del.Size = new System.Drawing.Size(145, 23);
            this.btn_Wword_del.TabIndex = 27;
            this.btn_Wword_del.Text = "삭제";
            this.btn_Wword_del.UseVisualStyleBackColor = true;
            this.btn_Wword_del.Click += new System.EventHandler(this.btn_Wword_del_Click);
            // 
            // txt_search
            // 
            this.txt_search.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_search.Location = new System.Drawing.Point(540, 79);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(285, 39);
            this.txt_search.TabIndex = 28;
            this.txt_search.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_search_KeyDown);
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(829, 78);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(145, 20);
            this.btn_search.TabIndex = 29;
            this.btn_search.Text = "검색";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_copy
            // 
            this.btn_copy.Location = new System.Drawing.Point(829, 100);
            this.btn_copy.Name = "btn_copy";
            this.btn_copy.Size = new System.Drawing.Size(145, 21);
            this.btn_copy.TabIndex = 30;
            this.btn_copy.Text = "단어 가져오기";
            this.btn_copy.UseVisualStyleBackColor = true;
            this.btn_copy.Click += new System.EventHandler(this.btn_copy_Click);
            // 
            // CB_Hardmode
            // 
            this.CB_Hardmode.AutoSize = true;
            this.CB_Hardmode.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.CB_Hardmode.Location = new System.Drawing.Point(103, 135);
            this.CB_Hardmode.Name = "CB_Hardmode";
            this.CB_Hardmode.Size = new System.Drawing.Size(100, 16);
            this.CB_Hardmode.TabIndex = 31;
            this.CB_Hardmode.Text = "Hard Mode!";
            this.CB_Hardmode.UseVisualStyleBackColor = true;
            this.CB_Hardmode.MouseHover += new System.EventHandler(this.CB_Hardmode_MouseHover);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(101, 221);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 12);
            this.label9.TabIndex = 32;
            this.label9.Text = "단어 등록";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 515);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.CB_Hardmode);
            this.Controls.Add(this.btn_copy);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.btn_Wword_del);
            this.Controls.Add(this.txt_Wword_cnt);
            this.Controls.Add(this.btn_start_test);
            this.Controls.Add(this.btn_mean_visible);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_WwT);
            this.Controls.Add(this.list_Wword);
            this.Controls.Add(this.txt_wordcnt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_incornum);
            this.Controls.Add(this.txt_cornum);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_redution);
            this.Controls.Add(this.btn_extention);
            this.Controls.Add(this.btn_listdel);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Smean);
            this.Controls.Add(this.txt_Sword);
            this.Controls.Add(this.txt_result);
            this.Controls.Add(this.list_words);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_mean);
            this.Controls.Add(this.txt_word);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "단어맞추기";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txt_word;
        private System.Windows.Forms.TextBox txt_mean;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.ListView list_words;
        private System.Windows.Forms.ColumnHeader 단어;
        private System.Windows.Forms.ColumnHeader 뜻;
        private System.Windows.Forms.Label txt_result;
        private System.Windows.Forms.TextBox txt_Sword;
        private System.Windows.Forms.TextBox txt_Smean;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_listdel;
        private System.Windows.Forms.Button btn_extention;
        private System.Windows.Forms.Button btn_redution;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label txt_cornum;
        private System.Windows.Forms.Label txt_incornum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label txt_wordcnt;
        private System.Windows.Forms.ListView list_Wword;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button btn_WwT;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_mean_visible;
        private System.Windows.Forms.Button btn_start_test;
        private System.Windows.Forms.Label txt_Wword_cnt;
        private System.Windows.Forms.Button btn_Wword_del;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_copy;
        private System.Windows.Forms.CheckBox CB_Hardmode;
        private System.Windows.Forms.ToolTip tp_Hard_Mode_discription;
        private System.Windows.Forms.Label label9;
    }
}

