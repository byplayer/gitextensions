﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ResourceManager.Translation
{
    public class Translate: ITranslate
    {
        public virtual void AddTranslationItems(Translation translation)
        {
            TranslationUtl.AddTranslationItemsFromFields(GetType().Name, this, translation);
        }

        public virtual void TranslateItems(Translation translation)
        {
            TranslationUtl.TranslateItemsFromFields(GetType().Name, this, translation);
        }
    }
}
