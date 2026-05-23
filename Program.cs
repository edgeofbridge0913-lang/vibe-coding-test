using System;
using System.Drawing;
using System.Windows.Forms;

namespace DinosaurGuideApp
{
    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }
    }

    public class MainForm : Form
    {
        private readonly Button _trexButton;
        private readonly Button _triceratopsButton;
        private readonly TextBox _descriptionBox;

        public MainForm()
        {
            Text = "恐竜図鑑アプリ";
            ClientSize = new Size(560, 360);
            MinimumSize = new Size(520, 320);
            FormBorderStyle = FormBorderStyle.Sizable;
            MaximizeBox = true;
            StartPosition = FormStartPosition.CenterScreen;

            var leftPanel = new Panel
            {
                Location = new Point(12, 12),
                Size = new Size(180, 336),
                Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left,
            };
            Controls.Add(leftPanel);

            var titleLabel = new Label
            {
                Text = "恐竜を選んでね",
                Font = new Font("Meiryo", 14, FontStyle.Bold),
                AutoSize = true,
                Location = new Point(0, 0),
            };
            leftPanel.Controls.Add(titleLabel);

            _trexButton = new Button
            {
                Text = "ティラノサウルス",
                Size = new Size(180, 45),
                Location = new Point(0, 60),
            };
            _trexButton.Click += (sender, args) => ShowTyrannosaurus();
            leftPanel.Controls.Add(_trexButton);

            _triceratopsButton = new Button
            {
                Text = "トリケラトプス",
                Size = new Size(180, 45),
                Location = new Point(0, 125),
            };
            _triceratopsButton.Click += (sender, args) => ShowTriceratops();
            leftPanel.Controls.Add(_triceratopsButton);

            _descriptionBox = new TextBox
            {
                Multiline = true,
                ReadOnly = true,
                ScrollBars = ScrollBars.Vertical,
                Font = new Font("Meiryo", 12),
                Location = new Point(210, 12),
                Size = new Size(338, 336),
                BackColor = Color.White,
                Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right,
            };
            Controls.Add(_descriptionBox);

            ShowWelcomeText();
        }

        private void ShowWelcomeText()
        {
            _descriptionBox.Text = "左のボタンを押すと、恐竜の生息時代や特徴が表示されます。\r\n\r\n" +
                                   "ティラノサウルスかトリケラトプスを選んでみましょう。";
        }

        private void ShowTyrannosaurus()
        {
            _descriptionBox.Text = "ティラノサウルス:\r\n" +
                                   "・約6800万〜6600万年前の白亜紀後期に生息\r\n" +
                                   "・体長は約12メートルにもなる大きな肉食恐竜\r\n" +
                                   "・強いあごと大きな歯で獲物を捕まえました\r\n" +
                                   "・大きな後ろ足と小さな前あしが特徴です";
        }

        private void ShowTriceratops()
        {
            _descriptionBox.Text = "トリケラトプス:\r\n" +
                                   "・約6800万〜6600万年前の白亜紀後期に生息\r\n" +
                                   "・三つの角と大きな襟飾りを持つ草食恐竜\r\n" +
                                   "・頭の角で敵から身を守ったと考えられています\r\n" +
                                   "・丈夫な体で群れを作って生活していた可能性があります";
        }
    }
}
