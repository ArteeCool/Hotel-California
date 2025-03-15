using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.ComponentModel;
//Это просто округленная кнопка. ВинФормы по стандарту не поддерживают это
public class RoundedButton : Button
{
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public int BorderRadius { get; set; } = 10; // Радиус скругления углов
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public Color BorderColor { get; set; } = Color.FromArgb(216, 59, 113); // Цвет границы
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public int BorderSize { get; internal set; }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);

        GraphicsPath path = new GraphicsPath();
        path.AddArc(0, 0, BorderRadius, BorderRadius, 180, 90);
        path.AddArc(Width - BorderRadius, 0, BorderRadius, BorderRadius, 270, 90);
        path.AddArc(Width - BorderRadius, Height - BorderRadius, BorderRadius, BorderRadius, 0, 90);
        path.AddArc(0, Height - BorderRadius, BorderRadius, BorderRadius, 90, 90);
        path.CloseFigure();

        this.Region = new Region(path); // Устанавливаем область видимости кнопки

        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
        using (Pen pen = new Pen(BorderColor, 2))
        {
            e.Graphics.DrawPath(pen, path); // Рисуем контур
        }
    }
}
