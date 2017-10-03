﻿using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XrmToolBox.Extensibility;
using XrmToolBox.Extensibility.Interfaces;

namespace MarketingListManager
{
    [Export(typeof(IXrmToolBoxPlugin)),
ExportMetadata("BackgroundColor", "Gold"),
ExportMetadata("PrimaryFontColor", "Black"),
ExportMetadata("SecondaryFontColor", "Black"),
      ExportMetadata("SmallImageBase64", "iVBORw0KGgoAAAANSUhEUgAAAEAAAABACAQAAAAAYLlVAAAABGdBTUEAALGPC/xhBQAAACBjSFJNAAB6JgAAgIQAAPoAAACA6AAAdTAAAOpgAAA6mAAAF3CculE8AAAAAmJLR0QAAKqNIzIAAAAJcEhZcwAADdcAAA3XAUIom3gAAAAHdElNRQfhCgMJACKTeK+jAAAEA0lEQVRo3u2YXWgUVxTHf3G3+TCuUpM2QnCtn5XYYrBVUFtpbCtqqtE+lYqKkNKKFHzoQ6GFIoo+lKLRF7VQAqZYJVrBimJiikqS1aRfMYmRQAxNWiMmGLFajZrxwXF25mbu5N67u4KQ/zzszDln7v+/59x75s6APwo4zg3+ppyXSSnSfK1zqCXTPv+X2fQK/nf4gLAiQyOHeKAr6wKW69g3JDuW1vFJENUoH9uLzPVcLx7i10NgvF8i04XCpAv+WjazQqME+zUFA1c8KfxJf4BEsdRF/x9TU0mVJrEvp4xpDNLAp/w1xJvFQuUSeNFGp3pwDmN87bn0aq6D+PGIdd7BxFWwlFauUU2EmTTzGyGm0EgP9cxwYhaQY5zxUawMDjhlK/2REG1UkEGjbdnhxGRSxaBhBjpY5CUUK/m0/31MNXXE+I43bEuWE3OP90n37SDD4z5WsIA49hCmhPES74BxEQTIBWQDGcmikcMkkekc5aHhHGhhXuIClrCakOEfLuCLxAU0cseQHqDGe2nSz3qYyLuGnbCFS8ECWp2FKKLTdX6TygRyMILnA5M4QDtN7GJcaon89wOzqCdin3cwh1uC/01WKa4Ci3p+YVBXVq2ne5UJ3mmaz8L1QVR+jWgc8z3XSwR/VLqP8kd+kNMvkdkCQUTw/8o3rNQowV4tuQBc9aTwqP4AiaLERf8/M1NJJavmh+wmH2iilIYh3jCFgSXo4p9kiJtMnq99LF3DzPuHfG5KWkQdbRwhixlc5iIh8qmmjZNMdmJKFJZenamAGnuA73mBDioJc962bHdismkYhr6fj1QJZbviUmo4Q4xtvGVbRjsxd5hLbuAc6OeeqYA49hGmmAkSby9JgiggvmuP4H4XSBnkAoLu2a/cCUW0sJGmoIDz0om1y4lZZvxqamFx0EsoPoxUMtCs/9HJBaGtmZSgiyjvGX8fiAULaJfugNzNtYeKBHIwghF4INsPZLGJt7nLacqVVkaSBeRxllft8yqKfdZ91Oi9uo/baoFHPL3ra8EbodmwC96lVIU+kwHPbX8I/lUJNOKYioBXhJuupzIDfg21kz7Pp0jx6XWb11I9Bza7VA9SZECVINLYwgMsLG6x9tnTP0EexSz2fTRlcELz9XSAclXaAn7gGFtII8rPVBAimzKOsdM1K1YYTcDX1QQct8O/ZAy9nAUqbMtXTkwO17TpW2X7B9H8kv27lXNUEuMz1tiWXCemj0kUaq2CAf6UfaSQ7WvCHGQ0C5nuWCzPgBc16AMh31hFPf9abbOWVAEi4gJC7GaZTwksatmo2mpkiEmn0bdOTNC2fIMuofpUimfgEvclMY/4XVeASQm6mUiRpATdz0IA3OCwLpEMjwHQT6khoX2nkAAAACV0RVh0ZGF0ZTpjcmVhdGUAMjAxNy0xMC0wM1QwOTowMDozNCswMjowMARTD6gAAAAldEVYdGRhdGU6bW9kaWZ5ADIwMTctMTAtMDNUMDk6MDA6MzQrMDI6MDB1DrcUAAAAGXRFWHRTb2Z0d2FyZQB3d3cuaW5rc2NhcGUub3Jnm+48GgAAAABJRU5ErkJggg=="),
    ExportMetadata("BigImageBase64", "iVBORw0KGgoAAAANSUhEUgAAAEAAAABACAQAAAAAYLlVAAAABGdBTUEAALGPC/xhBQAAACBjSFJNAAB6JgAAgIQAAPoAAACA6AAAdTAAAOpgAAA6mAAAF3CculE8AAAAAmJLR0QAAKqNIzIAAAAJcEhZcwAADdcAAA3XAUIom3gAAAAHdElNRQfhCgMJACKTeK+jAAAEA0lEQVRo3u2YXWgUVxTHf3G3+TCuUpM2QnCtn5XYYrBVUFtpbCtqqtE+lYqKkNKKFHzoQ6GFIoo+lKLRF7VQAqZYJVrBimJiikqS1aRfMYmRQAxNWiMmGLFajZrxwXF25mbu5N67u4KQ/zzszDln7v+/59x75s6APwo4zg3+ppyXSSnSfK1zqCXTPv+X2fQK/nf4gLAiQyOHeKAr6wKW69g3JDuW1vFJENUoH9uLzPVcLx7i10NgvF8i04XCpAv+WjazQqME+zUFA1c8KfxJf4BEsdRF/x9TU0mVJrEvp4xpDNLAp/w1xJvFQuUSeNFGp3pwDmN87bn0aq6D+PGIdd7BxFWwlFauUU2EmTTzGyGm0EgP9cxwYhaQY5zxUawMDjhlK/2REG1UkEGjbdnhxGRSxaBhBjpY5CUUK/m0/31MNXXE+I43bEuWE3OP90n37SDD4z5WsIA49hCmhPES74BxEQTIBWQDGcmikcMkkekc5aHhHGhhXuIClrCakOEfLuCLxAU0cseQHqDGe2nSz3qYyLuGnbCFS8ECWp2FKKLTdX6TygRyMILnA5M4QDtN7GJcaon89wOzqCdin3cwh1uC/01WKa4Ci3p+YVBXVq2ne5UJ3mmaz8L1QVR+jWgc8z3XSwR/VLqP8kd+kNMvkdkCQUTw/8o3rNQowV4tuQBc9aTwqP4AiaLERf8/M1NJJavmh+wmH2iilIYh3jCFgSXo4p9kiJtMnq99LF3DzPuHfG5KWkQdbRwhixlc5iIh8qmmjZNMdmJKFJZenamAGnuA73mBDioJc962bHdismkYhr6fj1QJZbviUmo4Q4xtvGVbRjsxd5hLbuAc6OeeqYA49hGmmAkSby9JgiggvmuP4H4XSBnkAoLu2a/cCUW0sJGmoIDz0om1y4lZZvxqamFx0EsoPoxUMtCs/9HJBaGtmZSgiyjvGX8fiAULaJfugNzNtYeKBHIwghF4INsPZLGJt7nLacqVVkaSBeRxllft8yqKfdZ91Oi9uo/baoFHPL3ra8EbodmwC96lVIU+kwHPbX8I/lUJNOKYioBXhJuupzIDfg21kz7Pp0jx6XWb11I9Bza7VA9SZECVINLYwgMsLG6x9tnTP0EexSz2fTRlcELz9XSAclXaAn7gGFtII8rPVBAimzKOsdM1K1YYTcDX1QQct8O/ZAy9nAUqbMtXTkwO17TpW2X7B9H8kv27lXNUEuMz1tiWXCemj0kUaq2CAf6UfaSQ7WvCHGQ0C5nuWCzPgBc16AMh31hFPf9abbOWVAEi4gJC7GaZTwksatmo2mpkiEmn0bdOTNC2fIMuofpUimfgEvclMY/4XVeASQm6mUiRpATdz0IA3OCwLpEMjwHQT6khoX2nkAAAACV0RVh0ZGF0ZTpjcmVhdGUAMjAxNy0xMC0wM1QwOTowMDozNCswMjowMARTD6gAAAAldEVYdGRhdGU6bW9kaWZ5ADIwMTctMTAtMDNUMDk6MDA6MzQrMDI6MDB1DrcUAAAAGXRFWHRTb2Z0d2FyZQB3d3cuaW5rc2NhcGUub3Jnm+48GgAAAABJRU5ErkJggg=="),
ExportMetadata("Name", "Ultimate Marketing List Manager"),
ExportMetadata("Description", "The Ultimate Marketing List Manager. Copy, delete or many more with marketing lists.")]
    public class Plugin: PluginBase
    {
        public override IXrmToolBoxPluginControl GetControl()
        {
            
            return new MainControl();
        }
    }
}