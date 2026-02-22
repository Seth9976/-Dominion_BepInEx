using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Threading
{
	// Token: 0x0200028B RID: 651
	[Serializable]
	public class WaitHandleCannotBeOpenedException : ApplicationException
	{
		// Token: 0x06002C46 RID: 11334 RVA: 0x000E1D54 File Offset: 0x000DFF54
		// Note: this type is marked as 'beforefieldinit'.
		static WaitHandleCannotBeOpenedException()
		{
			Il2CppClassPointerStore<WaitHandleCannotBeOpenedException>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "WaitHandleCannotBeOpenedException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WaitHandleCannotBeOpenedException>.NativeClassPtr);
			WaitHandleCannotBeOpenedException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitHandleCannotBeOpenedException>.NativeClassPtr, 100670327);
			WaitHandleCannotBeOpenedException.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitHandleCannotBeOpenedException>.NativeClassPtr, 100670328);
			WaitHandleCannotBeOpenedException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitHandleCannotBeOpenedException>.NativeClassPtr, 100670329);
		}

		// Token: 0x06002C47 RID: 11335 RVA: 0x000E1DC0 File Offset: 0x000DFFC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 333570, XrefRangeEnd = 333575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WaitHandleCannotBeOpenedException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WaitHandleCannotBeOpenedException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitHandleCannotBeOpenedException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C48 RID: 11336 RVA: 0x000E1DFC File Offset: 0x000DFFFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 333575, XrefRangeEnd = 333577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WaitHandleCannotBeOpenedException(string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WaitHandleCannotBeOpenedException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitHandleCannotBeOpenedException.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002C49 RID: 11337 RVA: 0x000E1E48 File Offset: 0x000E0048
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WaitHandleCannotBeOpenedException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WaitHandleCannotBeOpenedException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitHandleCannotBeOpenedException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C4A RID: 11338 RVA: 0x0000F6B5 File Offset: 0x0000D8B5
		public WaitHandleCannotBeOpenedException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400267B RID: 9851
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400267C RID: 9852
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x0400267D RID: 9853
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;
	}
}
