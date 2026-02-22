using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x020000D2 RID: 210
	public class PreloadData : Object
	{
		// Token: 0x060011E9 RID: 4585 RVA: 0x0000AE00 File Offset: 0x00009000
		// Note: this type is marked as 'beforefieldinit'.
		static PreloadData()
		{
			Il2CppClassPointerStore<PreloadData>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "PreloadData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PreloadData>.NativeClassPtr);
			PreloadData.NativeMethodInfoPtr_PreloadDataDontStripMe_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PreloadData>.NativeClassPtr, 100664543);
		}

		// Token: 0x060011EA RID: 4586 RVA: 0x000479C0 File Offset: 0x00045BC0
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PreloadDataDontStripMe()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PreloadData.NativeMethodInfoPtr_PreloadDataDontStripMe_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011EB RID: 4587 RVA: 0x0000AE39 File Offset: 0x00009039
		public PreloadData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000D59 RID: 3417
		private static readonly IntPtr NativeMethodInfoPtr_PreloadDataDontStripMe_Internal_Void_0;
	}
}
