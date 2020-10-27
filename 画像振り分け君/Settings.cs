using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageResizeFolder
{
    public class Settings
    {
        enum ExceptionMode
        {
            Uppercase,
            Lowercase
        }
        enum FileDate
        {
            ExchangeDate,
            OriginalDate
        }
        enum UnitMode
        {
            Percent,
            Pixel
        }
        enum ResizeMode
        {
            Nearest,
            Linear,
            Cubic,
            Area,
            Lanczos4,
            LinearExact
        }
        enum ImageFileMode
        {
            Jpeg,
            Png,
            Bmp,
            NotChange
        }
        enum SaveMode
        {
            ParentFolder,
            OtherFolder
        }
        enum AspectMode
        {
            Height,
            Width,
            Long,
            Short
        }
    }
}
