using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VVVV.AForge.Video.DirectShow
{
    public delegate void UpdateBufferEventHandler(object sender, UpdateBufferEventArgs eventArgs);
    public class UpdateBufferEventArgs : EventArgs
    {
        private IntPtr buffer;
        private int bufferLen;
        private int width;
        private int height;
        public UpdateBufferEventArgs(IntPtr buffer, int bufferLen, int width, int height)
        {
            this.buffer = buffer;
            this.bufferLen = bufferLen;
            this.width = width;
            this.height = height;
        }

        public IntPtr Buffer
        {
            get { return buffer; }
        }
        public int BufferLen
        {
            get { return bufferLen; }
        }
        public int Width
        {
            get { return width; }
        }
        public int Height
        {
            get { return height; }
        }
    }
}
