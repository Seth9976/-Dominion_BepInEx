using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace SA.Foundation.PropertyDrawers.Attributes
{
	// Token: 0x0200035D RID: 861
	public class SA_PD_PRInsertionDecoratorAttribute : PropertyAttribute
	{
		// Token: 0x060033D6 RID: 13270 RVA: 0x000143CE File Offset: 0x000125CE
		// Note: this type is marked as 'beforefieldinit'.
		static SA_PD_PRInsertionDecoratorAttribute()
		{
			Il2CppClassPointerStore<SA_PD_PRInsertionDecoratorAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "SA.Foundation.PropertyDrawers.Attributes", "SA_PD_PRInsertionDecoratorAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SA_PD_PRInsertionDecoratorAttribute>.NativeClassPtr);
			SA_PD_PRInsertionDecoratorAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_PD_PRInsertionDecoratorAttribute>.NativeClassPtr, 100669907);
		}

		// Token: 0x060033D7 RID: 13271 RVA: 0x000D729C File Offset: 0x000D549C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 40944, RefRangeEnd = 40950, XrefRangeStart = 40944, XrefRangeEnd = 40950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SA_PD_PRInsertionDecoratorAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SA_PD_PRInsertionDecoratorAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_PD_PRInsertionDecoratorAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060033D8 RID: 13272 RVA: 0x00014407 File Offset: 0x00012607
		public SA_PD_PRInsertionDecoratorAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400300D RID: 12301
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
