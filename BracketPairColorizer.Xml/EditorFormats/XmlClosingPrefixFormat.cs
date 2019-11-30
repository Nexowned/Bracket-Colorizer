using System;
using System.ComponentModel.Composition;
using System.Windows.Media;
using Microsoft.VisualStudio.Text.Classification;
using Microsoft.VisualStudio.Utilities;

namespace BracketPairColorizer.Xml.EditorFormats
{
  [Export(typeof(EditorFormatDefinition))]
  [ClassificationType(ClassificationTypeNames = XmlConstants.XML_CLOSING_PREFIX)]
  [Name(XmlConstants.XML_CLOSING_PREFIX)]
  [UserVisible(true)]
  [Order(Before = Priority.High, After = Priority.High)]
  internal sealed class XmlClosingPrefixFormat : ClassificationFormatDefinition 
  {
    public XmlClosingPrefixFormat() {
      this.DisplayName = "BracketPairColorizer XML Prefix Closing";
      this.ForegroundColor = Colors.OrangeRed;
    }
  }
}
