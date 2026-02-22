using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace UnityEngine.Bindings
{
	// Token: 0x02000008 RID: 8
	public class VisibleToOtherModulesAttribute : Attribute
	{
		// Token: 0x06000024 RID: 36 RVA: 0x00002C18 File Offset: 0x00000E18
		// Note: this type is marked as 'beforefieldinit'.
		static VisibleToOtherModulesAttribute()
		{
			Il2CppClassPointerStore<VisibleToOtherModulesAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.SharedInternalsModule.dll", "UnityEngine.Bindings", "VisibleToOtherModulesAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VisibleToOtherModulesAttribute>.NativeClassPtr);
			VisibleToOtherModulesAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisibleToOtherModulesAttribute>.NativeClassPtr, 100663306);
			VisibleToOtherModulesAttribute.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisibleToOtherModulesAttribute>.NativeClassPtr, 100663307);
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00002C70 File Offset: 0x00000E70
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 12105, RefRangeEnd = 12219, XrefRangeStart = 12105, XrefRangeEnd = 12219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VisibleToOtherModulesAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VisibleToOtherModulesAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisibleToOtherModulesAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00002CAC File Offset: 0x00000EAC
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 12105, RefRangeEnd = 12219, XrefRangeStart = 12105, XrefRangeEnd = 12219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VisibleToOtherModulesAttribute([Optional] Il2CppStringArray modules)
		{
			if (modules == null)
			{
				modules = new Il2CppStringArray(0L);
			}
			this..ctor(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VisibleToOtherModulesAttribute>.NativeClassPtr));
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(modules);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisibleToOtherModulesAttribute.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00002223 File Offset: 0x00000423
		public VisibleToOtherModulesAttribute(params string[] modules)
			: this(new Il2CppStringArray(modules))
		{
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00002231 File Offset: 0x00000431
		public VisibleToOtherModulesAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400000E RID: 14
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400000F RID: 15
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStringArray_0;
	}
}
