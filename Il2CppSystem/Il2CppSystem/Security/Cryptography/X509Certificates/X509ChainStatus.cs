using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Security.Cryptography.X509Certificates
{
	// Token: 0x02000098 RID: 152
	public sealed class X509ChainStatus : ValueType
	{
		// Token: 0x0600091C RID: 2332 RVA: 0x00031D48 File Offset: 0x0002FF48
		// Note: this type is marked as 'beforefieldinit'.
		static X509ChainStatus()
		{
			Il2CppClassPointerStore<X509ChainStatus>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Security.Cryptography.X509Certificates", "X509ChainStatus");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<X509ChainStatus>.NativeClassPtr);
			X509ChainStatus.NativeFieldInfoPtr_status = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509ChainStatus>.NativeClassPtr, "status");
			X509ChainStatus.NativeFieldInfoPtr_info = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509ChainStatus>.NativeClassPtr, "info");
			X509ChainStatus.NativeMethodInfoPtr__ctor_Internal_Void_X509ChainStatusFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509ChainStatus>.NativeClassPtr, 100664476);
			X509ChainStatus.NativeMethodInfoPtr_GetInformation_Internal_Static_String_X509ChainStatusFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509ChainStatus>.NativeClassPtr, 100664477);
		}

		// Token: 0x0600091D RID: 2333 RVA: 0x00031DC8 File Offset: 0x0002FFC8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 42750, RefRangeEnd = 42751, XrefRangeStart = 42746, XrefRangeEnd = 42750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe X509ChainStatus(X509ChainStatusFlags flag)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<X509ChainStatus>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref flag;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509ChainStatus.NativeMethodInfoPtr__ctor_Internal_Void_X509ChainStatusFlags_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600091E RID: 2334 RVA: 0x00031E14 File Offset: 0x00030014
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42751, XrefRangeEnd = 42755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetInformation(X509ChainStatusFlags flags)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref flags;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509ChainStatus.NativeMethodInfoPtr_GetInformation_Internal_Static_String_X509ChainStatusFlags_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600091F RID: 2335 RVA: 0x00005B59 File Offset: 0x00003D59
		public X509ChainStatus(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000920 RID: 2336 RVA: 0x00005B62 File Offset: 0x00003D62
		public X509ChainStatus()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<X509ChainStatus>.NativeClassPtr))
		{
		}

		// Token: 0x170002C9 RID: 713
		// (get) Token: 0x06000921 RID: 2337 RVA: 0x00031E4C File Offset: 0x0003004C
		// (set) Token: 0x06000922 RID: 2338 RVA: 0x00005B74 File Offset: 0x00003D74
		public unsafe X509ChainStatusFlags status
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509ChainStatus.NativeFieldInfoPtr_status);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509ChainStatus.NativeFieldInfoPtr_status)) = value;
			}
		}

		// Token: 0x170002CA RID: 714
		// (get) Token: 0x06000923 RID: 2339 RVA: 0x00031E74 File Offset: 0x00030074
		// (set) Token: 0x06000924 RID: 2340 RVA: 0x00005B8F File Offset: 0x00003D8F
		public unsafe string info
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509ChainStatus.NativeFieldInfoPtr_info);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509ChainStatus.NativeFieldInfoPtr_info), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040006F1 RID: 1777
		private static readonly IntPtr NativeFieldInfoPtr_status;

		// Token: 0x040006F2 RID: 1778
		private static readonly IntPtr NativeFieldInfoPtr_info;

		// Token: 0x040006F3 RID: 1779
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_X509ChainStatusFlags_0;

		// Token: 0x040006F4 RID: 1780
		private static readonly IntPtr NativeMethodInfoPtr_GetInformation_Internal_Static_String_X509ChainStatusFlags_0;
	}
}
