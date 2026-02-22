using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.InteropServices
{
	// Token: 0x0200043D RID: 1085
	public sealed class InterfaceTypeAttribute : Attribute
	{
		// Token: 0x06004297 RID: 17047 RVA: 0x001323E8 File Offset: 0x001305E8
		// Note: this type is marked as 'beforefieldinit'.
		static InterfaceTypeAttribute()
		{
			Il2CppClassPointerStore<InterfaceTypeAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.InteropServices", "InterfaceTypeAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InterfaceTypeAttribute>.NativeClassPtr);
			InterfaceTypeAttribute.NativeFieldInfoPtr__val = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceTypeAttribute>.NativeClassPtr, "_val");
			InterfaceTypeAttribute.NativeMethodInfoPtr__ctor_Public_Void_ComInterfaceType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InterfaceTypeAttribute>.NativeClassPtr, 100672963);
		}

		// Token: 0x06004298 RID: 17048 RVA: 0x00132440 File Offset: 0x00130640
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InterfaceTypeAttribute(ComInterfaceType interfaceType)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InterfaceTypeAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref interfaceType;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InterfaceTypeAttribute.NativeMethodInfoPtr__ctor_Public_Void_ComInterfaceType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004299 RID: 17049 RVA: 0x0001979A File Offset: 0x0001799A
		public InterfaceTypeAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700110B RID: 4363
		// (get) Token: 0x0600429A RID: 17050 RVA: 0x00132488 File Offset: 0x00130688
		// (set) Token: 0x0600429B RID: 17051 RVA: 0x000197A3 File Offset: 0x000179A3
		public unsafe ComInterfaceType _val
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InterfaceTypeAttribute.NativeFieldInfoPtr__val);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InterfaceTypeAttribute.NativeFieldInfoPtr__val)) = value;
			}
		}

		// Token: 0x0400361B RID: 13851
		private static readonly IntPtr NativeFieldInfoPtr__val;

		// Token: 0x0400361C RID: 13852
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ComInterfaceType_0;
	}
}
