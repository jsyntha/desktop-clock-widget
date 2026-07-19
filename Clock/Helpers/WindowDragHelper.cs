namespace Clock.Helpers
{
    internal class WindowDragHelper
    {
        private bool _isDragging = false;
        private Point _mouseDownPosition;
        private Point _formPosition;
        private readonly Form _form;

        public WindowDragHelper(Form form)
        {
            _form = form;
        }

        public void StartDrag(MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;

            _isDragging = true;

            _mouseDownPosition = Cursor.Position;
            _formPosition = _form.Location;
        }

        public void MoveDrag()
        {
            if (!_isDragging) { return; }
            Point difference = Cursor.Position - (Size)_mouseDownPosition;
            _form.Location = _formPosition + (Size)difference;
        }

        public void EndDrag(MouseEventArgs e)
        {
            _isDragging = false;
        }
    }
}
