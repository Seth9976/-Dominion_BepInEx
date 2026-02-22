using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem
{
	// Token: 0x020000C9 RID: 201
	[Serializable]
	public class MemberAccessException : SystemException
	{
		// Token: 0x06000DBC RID: 3516 RVA: 0x00060728 File Offset: 0x0005E928
		// Note: this type is marked as 'beforefieldinit'.
		static MemberAccessException()
		{
			Il2CppClassPointerStore<MemberAccessException>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "MemberAccessException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MemberAccessException>.NativeClassPtr);
			MemberAccessException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemberAccessException>.NativeClassPtr, 100665612);
			MemberAccessException.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemberAccessException>.NativeClassPtr, 100665613);
			MemberAccessException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemberAccessException>.NativeClassPtr, 100665614);
		}

		// Token: 0x06000DBD RID: 3517 RVA: 0x00060794 File Offset: 0x0005E994
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288361, XrefRangeEnd = 288366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MemberAccessException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MemberAccessException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemberAccessException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DBE RID: 3518 RVA: 0x000607D0 File Offset: 0x0005E9D0
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 288368, RefRangeEnd = 288383, XrefRangeStart = 288366, XrefRangeEnd = 288368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MemberAccessException(string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MemberAccessException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemberAccessException.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000DBF RID: 3519 RVA: 0x0006081C File Offset: 0x0005EA1C
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 41353, RefRangeEnd = 41374, XrefRangeStart = 41353, XrefRangeEnd = 41374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MemberAccessException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MemberAccessException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemberAccessException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DC0 RID: 3520 RVA: 0x000058E1 File Offset: 0x00003AE1
		public MemberAccessException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000BB7 RID: 2999
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000BB8 RID: 3000
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04000BB9 RID: 3001
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;
	}
}
