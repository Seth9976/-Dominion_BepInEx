using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Threading
{
	// Token: 0x0200026F RID: 623
	[Serializable]
	public class LockRecursionException : Exception
	{
		// Token: 0x06002AF2 RID: 10994 RVA: 0x000DD220 File Offset: 0x000DB420
		// Note: this type is marked as 'beforefieldinit'.
		static LockRecursionException()
		{
			Il2CppClassPointerStore<LockRecursionException>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "LockRecursionException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LockRecursionException>.NativeClassPtr);
			LockRecursionException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LockRecursionException>.NativeClassPtr, 100670125);
			LockRecursionException.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LockRecursionException>.NativeClassPtr, 100670126);
			LockRecursionException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LockRecursionException>.NativeClassPtr, 100670127);
		}

		// Token: 0x06002AF3 RID: 10995 RVA: 0x000DD28C File Offset: 0x000DB48C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 331597, XrefRangeEnd = 331601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LockRecursionException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LockRecursionException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LockRecursionException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002AF4 RID: 10996 RVA: 0x000DD2C8 File Offset: 0x000DB4C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 331601, XrefRangeEnd = 331605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LockRecursionException(string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LockRecursionException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LockRecursionException.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002AF5 RID: 10997 RVA: 0x000DD314 File Offset: 0x000DB514
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 331605, XrefRangeEnd = 331609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LockRecursionException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LockRecursionException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LockRecursionException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002AF6 RID: 10998 RVA: 0x0000EFDB File Offset: 0x0000D1DB
		public LockRecursionException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400258D RID: 9613
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400258E RID: 9614
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x0400258F RID: 9615
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;
	}
}
