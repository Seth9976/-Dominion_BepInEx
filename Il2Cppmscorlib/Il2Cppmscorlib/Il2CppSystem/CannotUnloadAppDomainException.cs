using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem
{
	// Token: 0x02000084 RID: 132
	[Serializable]
	public class CannotUnloadAppDomainException : SystemException
	{
		// Token: 0x060007FC RID: 2044 RVA: 0x000460AC File Offset: 0x000442AC
		// Note: this type is marked as 'beforefieldinit'.
		static CannotUnloadAppDomainException()
		{
			Il2CppClassPointerStore<CannotUnloadAppDomainException>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "CannotUnloadAppDomainException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CannotUnloadAppDomainException>.NativeClassPtr);
			CannotUnloadAppDomainException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CannotUnloadAppDomainException>.NativeClassPtr, 100664564);
			CannotUnloadAppDomainException.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CannotUnloadAppDomainException>.NativeClassPtr, 100664565);
			CannotUnloadAppDomainException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CannotUnloadAppDomainException>.NativeClassPtr, 100664566);
		}

		// Token: 0x060007FD RID: 2045 RVA: 0x00046118 File Offset: 0x00044318
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277308, XrefRangeEnd = 277313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CannotUnloadAppDomainException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CannotUnloadAppDomainException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CannotUnloadAppDomainException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007FE RID: 2046 RVA: 0x00046154 File Offset: 0x00044354
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277313, XrefRangeEnd = 277315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CannotUnloadAppDomainException(string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CannotUnloadAppDomainException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CannotUnloadAppDomainException.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007FF RID: 2047 RVA: 0x000461A0 File Offset: 0x000443A0
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 41353, RefRangeEnd = 41374, XrefRangeStart = 41353, XrefRangeEnd = 41374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CannotUnloadAppDomainException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CannotUnloadAppDomainException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CannotUnloadAppDomainException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000800 RID: 2048 RVA: 0x00004731 File Offset: 0x00002931
		public CannotUnloadAppDomainException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040005DA RID: 1498
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040005DB RID: 1499
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x040005DC RID: 1500
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;
	}
}
