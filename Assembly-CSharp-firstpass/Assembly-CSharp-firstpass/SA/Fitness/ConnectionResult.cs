using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using SA.Common.Models;

namespace SA.Fitness
{
	// Token: 0x02000331 RID: 817
	public class ConnectionResult : Result
	{
		// Token: 0x06002FF8 RID: 12280 RVA: 0x000CC8E8 File Offset: 0x000CAAE8
		// Note: this type is marked as 'beforefieldinit'.
		static ConnectionResult()
		{
			Il2CppClassPointerStore<ConnectionResult>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "SA.Fitness", "ConnectionResult");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConnectionResult>.NativeClassPtr);
			ConnectionResult.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConnectionResult>.NativeClassPtr, 100669648);
			ConnectionResult.NativeMethodInfoPtr__ctor_Public_Void_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConnectionResult>.NativeClassPtr, 100669649);
		}

		// Token: 0x06002FF9 RID: 12281 RVA: 0x000CC940 File Offset: 0x000CAB40
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 12105, RefRangeEnd = 12219, XrefRangeStart = 12105, XrefRangeEnd = 12219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConnectionResult()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConnectionResult>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConnectionResult.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002FFA RID: 12282 RVA: 0x000CC97C File Offset: 0x000CAB7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221415, XrefRangeEnd = 221422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConnectionResult(int resultCode, string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConnectionResult>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref resultCode;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConnectionResult.NativeMethodInfoPtr__ctor_Public_Void_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002FFB RID: 12283 RVA: 0x000124EC File Offset: 0x000106EC
		public ConnectionResult(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002DCC RID: 11724
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002DCD RID: 11725
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_String_0;
	}
}
