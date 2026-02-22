using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.InteropServices
{
	// Token: 0x0200043E RID: 1086
	public sealed class ComDefaultInterfaceAttribute : Attribute
	{
		// Token: 0x0600429C RID: 17052 RVA: 0x001324B0 File Offset: 0x001306B0
		// Note: this type is marked as 'beforefieldinit'.
		static ComDefaultInterfaceAttribute()
		{
			Il2CppClassPointerStore<ComDefaultInterfaceAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.InteropServices", "ComDefaultInterfaceAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ComDefaultInterfaceAttribute>.NativeClassPtr);
			ComDefaultInterfaceAttribute.NativeFieldInfoPtr__val = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComDefaultInterfaceAttribute>.NativeClassPtr, "_val");
			ComDefaultInterfaceAttribute.NativeMethodInfoPtr__ctor_Public_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComDefaultInterfaceAttribute>.NativeClassPtr, 100672964);
		}

		// Token: 0x0600429D RID: 17053 RVA: 0x00132508 File Offset: 0x00130708
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 14927, RefRangeEnd = 14932, XrefRangeStart = 14927, XrefRangeEnd = 14932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ComDefaultInterfaceAttribute(Type defaultInterface)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ComDefaultInterfaceAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(defaultInterface);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComDefaultInterfaceAttribute.NativeMethodInfoPtr__ctor_Public_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600429E RID: 17054 RVA: 0x000197BE File Offset: 0x000179BE
		public ComDefaultInterfaceAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700110C RID: 4364
		// (get) Token: 0x0600429F RID: 17055 RVA: 0x00132554 File Offset: 0x00130754
		// (set) Token: 0x060042A0 RID: 17056 RVA: 0x000197C7 File Offset: 0x000179C7
		public unsafe Type _val
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComDefaultInterfaceAttribute.NativeFieldInfoPtr__val);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComDefaultInterfaceAttribute.NativeFieldInfoPtr__val), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400361D RID: 13853
		private static readonly IntPtr NativeFieldInfoPtr__val;

		// Token: 0x0400361E RID: 13854
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Type_0;
	}
}
