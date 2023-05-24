using Syncfusion.Maui.Scheduler;
using System.Collections.ObjectModel;

namespace Maui_Scheduler;

public partial class MainPage : ContentPage
{
    public MainPage()
    {

        InitializeComponent();
        var timeRegions = new ObservableCollection<SchedulerTimeRegion>();
        var timeRegion = new SchedulerTimeRegion()
        {
            StartTime = DateTime.Today.AddHours(13),
            EndTime = DateTime.Today.AddHours(14),
            Text = "Lunch",
            EnablePointerInteraction = false,
            RecurrenceRule = "FERQ:DAILY,INTERVAL=1"
        };

        timeRegions.Add(timeRegion);
        this.Scheduler.DaysView.TimeRegions = timeRegions;
        this.Scheduler.TimelineView.TimeRegions = timeRegions;

    }
}

