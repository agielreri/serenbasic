﻿using Serenity.ComponentModel;
using System;

namespace SerenBasic.BasicSamples.Columns
{
    [ColumnsScript("BasicSamples.DragDropSample")]
    [BasedOnRow(typeof(Entities.DragDropSampleRow), CheckNames = true)]
    public class DragDropSampleColumns
    {
        [EditLink, Width(300)]
        public String Title { get; set; }
    }
}