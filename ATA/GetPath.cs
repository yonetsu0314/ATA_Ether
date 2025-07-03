using System;
using System.Collections.Generic;
using System.Text;

namespace MyLib {
    class GetPath {
        private string _AppPath;
        private string _AppNameWithOutExtention;
        private string _AppNameWithExtention;
        private string _AppDir;

        public GetPath() {
            _AppPath = System.Reflection.Assembly.GetEntryAssembly().Location;
            _AppDir = System.IO.Path.GetDirectoryName(_AppPath) + "\\";
            _AppNameWithOutExtention = System.IO.Path.GetFileNameWithoutExtension(_AppPath);
            _AppNameWithExtention = System.IO.Path.GetFileName(_AppPath);
        }

        public string AppPath {
            get { return _AppPath; }
            set { _AppPath = value; }
        }

        public string AppNameWithOutExtention {
            get { return _AppNameWithOutExtention; }
            set { _AppNameWithOutExtention = value; }
        }

        public string AppNameWithExtention {
            get { return _AppNameWithExtention; }
            set { _AppNameWithExtention = value; }
        }

        public string AppDir {
            get { return _AppDir; }
            set { _AppDir = value; }
        }
    }
}
