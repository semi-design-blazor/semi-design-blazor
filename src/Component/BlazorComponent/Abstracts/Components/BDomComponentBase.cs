namespace BlazorComponent
{
    public abstract class BDomComponentBase : BComponentBase, IHasProviderComponent
    {
        public BDomComponentBase()
        {
            CssProvider.StaticClass = () => Class;
            CssProvider.StaticStyle = () => Style;
            OnWatcherInitialized();
        }

        [Parameter]
        public string Id { get; set; }

        /// <summary>
        /// Specifies one or more class names for an DOM element.
        /// </summary>
        [Parameter]
        public string Class { get; set; }

        /// <summary>
        /// Specifies an inline style for an DOM element.
        /// </summary>
        [Parameter]
        public string Style { get; set; }

        /// <summary>
        /// Custom attributes
        /// </summary>
        [Parameter(CaptureUnmatchedValues = true)]
        public virtual IDictionary<string, object> Attributes { get; set; } = new Dictionary<string, object>();

        protected const int BROWSER_RENDER_INTERVAL = 16;

        private ElementReference _ref;
        private ElementReference? _prevRef;
        private bool _elementReferenceChanged;

        public ComponentCssProvider CssProvider { get; } = new();

        /// <summary>
        /// Returned ElementRef reference for DOM element.
        /// </summary>
        public virtual ElementReference Ref
        {
            get => _ref;
            set
            {
                if (_prevRef.HasValue)
                {
                    if (_prevRef.Value.Id != value.Id)
                    {
                        _prevRef = value;
                        _elementReferenceChanged = true;
                    }
                }
                else
                {
                    _prevRef = value;
                }

                _ref = value;
            }
        }

        protected virtual void OnWatcherInitialized()
        {
        }

        protected override void OnInitialized()
        {
            Id ??= Guid.NewGuid().ToString("N");
            base.OnInitialized();
            SetComponentClass();
        }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            await base.OnAfterRenderAsync(firstRender);

            if (_elementReferenceChanged)
            {
                _elementReferenceChanged = false;
                await OnElementReferenceChangedAsync();
            }
        }

        protected virtual Task OnElementReferenceChangedAsync()
        {
            return Task.CompletedTask;
        }

        protected virtual void SetComponentClass()
        {
        }

        public EventCallback<TValue> CreateEventCallback<TValue>(Func<TValue, Task> callback)
        {
            return EventCallback.Factory.Create(this, callback);
        }

        public EventCallback CreateEventCallback(Func<Task> callback)
        {
            return EventCallback.Factory.Create(this, callback);
        }

        public EventCallback<TValue> CreateEventCallback<TValue>(Action<TValue> callback)
        {
            return EventCallback.Factory.Create(this, callback);
        }

        public EventCallback CreateEventCallback(Action callback)
        {
            return EventCallback.Factory.Create(this, callback);
        }
    }
}
