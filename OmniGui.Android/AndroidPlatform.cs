using System;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using Android.App;

namespace OmniGui.Android
{
    public class AndroidPlatform
    {
        private readonly Activity mainActivity;
        private readonly ISubject<Layout> focusedElementSubject = new Subject<Layout>();

        public AndroidPlatform(OmniGuiView view, Activity mainActivity)
        {
            this.mainActivity = mainActivity;
            TextEngine = new AndroidTextEngine();
            //EventSource = new AndroidEventSource(view, mainActivity);            
        }
        public ITextEngine TextEngine { get; }
        public IEventSource EventSource { get; }
        public IObservable<Layout> FocusedElement => focusedElementSubject.DistinctUntilChanged();
        public void SetFocusedElement(Layout layout)
        {         
            focusedElementSubject.OnNext(layout);
        }
    }
}