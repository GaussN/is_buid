using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace BUILD.modules
{
    public class ColorService
    {
        private string _filePath = "./colors.txt";
        public Color bgColor { get; private set; } = Color.FromArgb(240, 240, 240);

        public Color fgColor { get; private set; } = Color.FromArgb(0, 0, 0);

        //не только для gridа, но и для полей ввода
        public Color grBgColor { get; private set; } = Color.FromArgb(255, 255, 255);
        public Color grFgColor { get; private set; } = Color.FromArgb(230, 230, 230);
        public Color btBgColor { get; private set; } = Color.FromArgb(240, 240, 240);
        public Color btFgColor { get; private set; } = Color.FromArgb(0, 0, 0);

        private string _colorSettingsString
        {
            get =>
                $"{bgColor.R} {bgColor.G} {bgColor.B} " +
                $"{fgColor.R} {fgColor.G} {fgColor.B} " +
                $"{grBgColor.R} {grBgColor.G} {grBgColor.B} " +
                $"{grFgColor.R} {grFgColor.G} {grFgColor.B} " +
                $"{btBgColor.R} {btBgColor.G} {btBgColor.B} " +
                $"{btFgColor.R} {btFgColor.G} {btFgColor.B}";

        }

        public ColorService()
        {
            if (!File.Exists(_filePath))
                File.Create(_filePath).Close();
            using (var stream = new StreamReader(_filePath))
            {
                var colors = stream.ReadLine();
                if (colors == null || colors==String.Empty)
                    using (var writer = new StreamWriter(_filePath))
                        writer.Write(_colorSettingsString);

                var color = colors.Split(' ');

                /*
                 о не! это опять магические числа!
                 */
                bgColor = Color.FromArgb(int.Parse(color[0]), int.Parse(color[1]), int.Parse(color[2]));
                fgColor = Color.FromArgb(int.Parse(color[3]), int.Parse(color[4]), int.Parse(color[5]));
                grBgColor = Color.FromArgb(int.Parse(color[6]), int.Parse(color[7]), int.Parse(color[8]));
                grFgColor = Color.FromArgb(int.Parse(color[9]), int.Parse(color[10]), int.Parse(color[11]));
                btBgColor = Color.FromArgb(int.Parse(color[12]), int.Parse(color[13]), int.Parse(color[14]));
                btFgColor = Color.FromArgb(int.Parse(color[15]), int.Parse(color[16]), int.Parse(color[17]));
            }
        }

        public void UpdateColor(Form form)
        {
            UpdateAllBgFg(form);
            UpdateGrid(form);
            UpdateButton(form);
        }

        private void setColors(Control control, Color bg, Color fg)
        {
            control.BackColor = bg;
            control.ForeColor = fg;
        }

        public void UpdateButton(Form form)
        {
            var cont = form.Controls;
            for (int i = 0; i < cont.Count; i++)
            {
                if (cont[i] is Button but)
                {
                    setColors(cont[i], btBgColor, btFgColor);
                }
            }
        }
        
        public void UpdateAllBgFg(Form form)
        {
            var cont = form.Controls;
            for (int i = 0; i < cont.Count; i++)
            {
                setColors(cont[i], bgColor, fgColor);
            }
        }
        
        public void UpdateGrid(Form form)
        {
            var cont = form.Controls;
            for (int i = 0; i < cont.Count; i++)
            {
                if (cont[i] is DataGridView || cont[i] is TextBox)
                {
                    setColors(cont[i], grBgColor, grFgColor);
                }
            }
        }
        
        
        
    }
}