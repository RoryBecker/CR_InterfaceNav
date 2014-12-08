using System.ComponentModel.Composition;
using DevExpress.CodeRush.Common;

namespace InterfaceJumping
{
  [Export(typeof(IVsixPluginExtension))]
  public class InterfaceJumpingExtension : IVsixPluginExtension { }
}