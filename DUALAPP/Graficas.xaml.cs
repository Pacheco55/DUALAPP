using Microcharts;
using SkiaSharp;
using System;
using System.Collections.Generic;

namespace DUALAPP;

public partial class Graficas : ContentPage
{
    Random random = new Random();

    public Graficas()
	{
		InitializeComponent();
        UpdateCharts();

    }
    private void UpdateCharts()
    {
        var entries = GenerateRandomEntries();

        BarChart.Chart = new BarChart
        {
            Entries = entries
        };
        LineChart.Chart = new LineChart
        {
            Entries = entries
        };
        PieChart.Chart = new PieChart
        {
            Entries = entries
        };
        DonutChart.Chart = new DonutChart
        {
            Entries = entries
        };
    }

    private ChartEntry[] GenerateRandomEntries()
    {
        var entries = new List<ChartEntry>();
        for (int i = 0; i < 12; i++)
        {
            entries.Add(new ChartEntry(random.Next(-500, 500))
            {
                Label = DateTime.Now.AddMonths(i).ToString("MMM"),
                ValueLabel = "$ " + random.Next(-500, 500).ToString(),
                Color = SKColor.Parse(String.Format("#{0:X6}", random.Next(0x1000000)))
            });
        }
        return entries.ToArray();
    }

    private void OnChangeColorsClicked(object sender, EventArgs e)
    {
        UpdateCharts();
    }
    private async void backpostlogin(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new postlogin());
    }
}

