using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace SA.Foundation.PropertyDrawers.Attributes
{
	// Token: 0x0200035F RID: 863
	public class SA_PD_ThingInsertionDecoratorAttribute : PropertyAttribute
	{
		// Token: 0x060033DC RID: 13276 RVA: 0x00014452 File Offset: 0x00012652
		// Note: this type is marked as 'beforefieldinit'.
		static SA_PD_ThingInsertionDecoratorAttribute()
		{
			Il2CppClassPointerStore<SA_PD_ThingInsertionDecoratorAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "SA.Foundation.PropertyDrawers.Attributes", "SA_PD_ThingInsertionDecoratorAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SA_PD_ThingInsertionDecoratorAttribute>.NativeClassPtr);
			SA_PD_ThingInsertionDecoratorAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_PD_ThingInsertionDecoratorAttribute>.NativeClassPtr, 100669909);
		}

		// Token: 0x060033DD RID: 13277 RVA: 0x000D7314 File Offset: 0x000D5514
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 40944, RefRangeEnd = 40950, XrefRangeStart = 40944, XrefRangeEnd = 40950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SA_PD_ThingInsertionDecoratorAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SA_PD_ThingInsertionDecoratorAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_PD_ThingInsertionDecoratorAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060033DE RID: 13278 RVA: 0x0001448B File Offset: 0x0001268B
		public SA_PD_ThingInsertionDecoratorAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400300F RID: 12303
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
