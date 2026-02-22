using System;
using Il2CppInterop.Runtime;

namespace UnityEngine.UIElements
{
	// Token: 0x02000005 RID: 5
	public class BindableElement : VisualElement
	{
		// Token: 0x06000018 RID: 24 RVA: 0x00002193 File Offset: 0x00000393
		// Note: this type is marked as 'beforefieldinit'.
		static BindableElement()
		{
			Il2CppClassPointerStore<BindableElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "BindableElement");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BindableElement>.NativeClassPtr);
		}

		// Token: 0x06000019 RID: 25 RVA: 0x000021B8 File Offset: 0x000003B8
		public BindableElement(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600001A RID: 26 RVA: 0x000021C1 File Offset: 0x000003C1
		// (set) Token: 0x0600001B RID: 27 RVA: 0x000021CE File Offset: 0x000003CE
		public IBinding binding
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600001C RID: 28 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x0600001D RID: 29 RVA: 0x000021E8 File Offset: 0x000003E8
		public string bindingPath
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x020001E6 RID: 486
		public new class UxmlFactory : UxmlFactory<BindableElement, BindableElement.UxmlTraits>
		{
		}

		// Token: 0x020001E7 RID: 487
		public new class UxmlTraits : VisualElement.UxmlTraits
		{
		}
	}
}
