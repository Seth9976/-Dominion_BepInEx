using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Threading
{
	// Token: 0x02000288 RID: 648
	[Serializable]
	public class ThreadStateException : SystemException
	{
		// Token: 0x06002C11 RID: 11281 RVA: 0x000E11B8 File Offset: 0x000DF3B8
		// Note: this type is marked as 'beforefieldinit'.
		static ThreadStateException()
		{
			Il2CppClassPointerStore<ThreadStateException>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "ThreadStateException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ThreadStateException>.NativeClassPtr);
			ThreadStateException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadStateException>.NativeClassPtr, 100670302);
			ThreadStateException.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadStateException>.NativeClassPtr, 100670303);
			ThreadStateException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadStateException>.NativeClassPtr, 100670304);
		}

		// Token: 0x06002C12 RID: 11282 RVA: 0x000E1224 File Offset: 0x000DF424
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 333424, XrefRangeEnd = 333429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ThreadStateException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ThreadStateException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadStateException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C13 RID: 11283 RVA: 0x000E1260 File Offset: 0x000DF460
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 333431, RefRangeEnd = 333433, XrefRangeStart = 333429, XrefRangeEnd = 333431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ThreadStateException(string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ThreadStateException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadStateException.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002C14 RID: 11284 RVA: 0x000E12AC File Offset: 0x000DF4AC
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 41353, RefRangeEnd = 41374, XrefRangeStart = 41353, XrefRangeEnd = 41374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ThreadStateException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ThreadStateException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadStateException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C15 RID: 11285 RVA: 0x0000F58E File Offset: 0x0000D78E
		public ThreadStateException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002658 RID: 9816
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002659 RID: 9817
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x0400265A RID: 9818
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;
	}
}
