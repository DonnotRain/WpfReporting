﻿namespace PrintPreviewGui.Reports
{
    public partial class TestReport1
    {
        public TestReport1()
        {
            InitializeComponent();

            for (var i = 1; i <= 100; i++)
            {
                ReportList.Items.Add(new ReportDataModel(i, $"Row {i}", $"This is the description of row number {i}"));
            }
        }
    }
}