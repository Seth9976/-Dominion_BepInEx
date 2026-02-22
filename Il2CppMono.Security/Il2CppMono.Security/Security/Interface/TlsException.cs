using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppMono.Security.Interface
{
	// Token: 0x02000027 RID: 39
	public sealed class TlsException : Exception
	{
		// Token: 0x0600020F RID: 527 RVA: 0x0000B3C4 File Offset: 0x000095C4
		// Note: this type is marked as 'beforefieldinit'.
		static TlsException()
		{
			Il2CppClassPointerStore<TlsException>.NativeClassPtr = IL2CPP.GetIl2CppClass("Mono.Security.dll", "Mono.Security.Interface", "TlsException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TlsException>.NativeClassPtr);
			TlsException.NativeFieldInfoPtr_alert = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TlsException>.NativeClassPtr, "alert");
			TlsException.NativeMethodInfoPtr__ctor_Public_Void_Alert_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TlsException>.NativeClassPtr, 100663572);
			TlsException.NativeMethodInfoPtr__ctor_Public_Void_AlertDescription_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TlsException>.NativeClassPtr, 100663573);
		}

		// Token: 0x06000210 RID: 528 RVA: 0x0000B430 File Offset: 0x00009630
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 10251, XrefRangeEnd = 10255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TlsException(Alert alert, string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TlsException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(alert);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TlsException.NativeMethodInfoPtr__ctor_Public_Void_Alert_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000211 RID: 529 RVA: 0x0000B490 File Offset: 0x00009690
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 10255, XrefRangeEnd = 10263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TlsException(AlertDescription description, string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TlsException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref description;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TlsException.NativeMethodInfoPtr__ctor_Public_Void_AlertDescription_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000212 RID: 530 RVA: 0x00002E46 File Offset: 0x00001046
		public TlsException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x06000213 RID: 531 RVA: 0x0000B4EC File Offset: 0x000096EC
		// (set) Token: 0x06000214 RID: 532 RVA: 0x00002E4F File Offset: 0x0000104F
		public unsafe Alert alert
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TlsException.NativeFieldInfoPtr_alert);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Alert>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TlsException.NativeFieldInfoPtr_alert), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000299 RID: 665
		private static readonly IntPtr NativeFieldInfoPtr_alert;

		// Token: 0x0400029A RID: 666
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Alert_String_0;

		// Token: 0x0400029B RID: 667
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_AlertDescription_String_0;
	}
}
