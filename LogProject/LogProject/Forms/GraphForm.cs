using LogProject.Database;
using Microsoft.EntityFrameworkCore;
using ScottPlot;

namespace LogProject.Forms
{
    public partial class GraphForm : Form
    {
        private readonly AppDbContext _dbContext;
        public GraphForm(AppDbContext dbContext)
        {
            InitializeComponent();
            _dbContext = dbContext;
            FillCmb();
            cmb.SelectedIndexChanged += (sender, args) => UpdatePlot();

            UpdatePlot();
        }

        private void FillCmb()
        {
            var routes = _dbContext.GeologicalObjects.Select(mp => mp.Type).Distinct().ToList();
            foreach (var route in routes)
            {
                cmb.Items.Add(route);
            }
            cmb.SelectedIndex = 0;
        }

        private void UpdatePlot()
        {
            formsPlot1.Plot.Clear();

            Plot plot = formsPlot1.Plot;

            if (cmb.SelectedItem == null) return;

            ObjectType selected = (ObjectType)cmb.SelectedItem;
            var points = _dbContext.GeologicalObjects
                                   .Where(mp => mp.Type == selected)
                                   .OrderBy(mp => mp.XCoordinates) // Сортировка по X, если нужно
                                   .ToList();

            double[] X = points.Select(p => (double)p.XCoordinates).ToArray();
            double[] Y = points.Select(p => (double)p.YCoordinates).ToArray();

            plot.Clear();
            var scatter = formsPlot1.Plot.Add.Scatter(X, Y);
            scatter.MarkerShape = MarkerShape.FilledCircle;
            scatter.MarkerSize = 5;

            plot.Axes.SetLimits(X.Min() - 1, X.Max() + 1, Y.Min() - 1, Y.Max() + 1);
            plot.Title($"Route {selected} Measurements");
            plot.XLabel("X Coordinate");
            plot.YLabel("Y Coordinate");
            formsPlot1.Refresh();
        }
    }
}
