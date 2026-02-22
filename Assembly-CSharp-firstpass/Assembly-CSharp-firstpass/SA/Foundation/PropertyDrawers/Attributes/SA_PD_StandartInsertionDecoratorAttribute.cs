using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace SA.Foundation.PropertyDrawers.Attributes
{
	// Token: 0x0200035E RID: 862
	public class SA_PD_StandartInsertionDecoratorAttribute : PropertyAttribute
	{
		// Token: 0x060033D9 RID: 13273 RVA: 0x00014410 File Offset: 0x00012610
		// Note: this type is marked as 'beforefieldinit'.
		static SA_PD_StandartInsertionDecoratorAttribute()
		{
			Il2CppClassPointerStore<SA_PD_StandartInsertionDecoratorAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "SA.Foundation.PropertyDrawers.Attributes", "SA_PD_StandartInsertionDecoratorAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SA_PD_StandartInsertionDecoratorAttribute>.NativeClassPtr);
			SA_PD_StandartInsertionDecoratorAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_PD_StandartInsertionDecoratorAttribute>.NativeClassPtr, 100669908);
		}

		// Token: 0x060033DA RID: 13274 RVA: 0x000D72D8 File Offset: 0x000D54D8
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 40944, RefRangeEnd = 40950, XrefRangeStart = 40944, XrefRangeEnd = 40950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SA_PD_StandartInsertionDecoratorAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SA_PD_StandartInsertionDecoratorAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_PD_StandartInsertionDecoratorAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060033DB RID: 13275 RVA: 0x00014449 File Offset: 0x00012649
		public SA_PD_StandartInsertionDecoratorAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400300E RID: 12302
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
