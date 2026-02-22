using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Reflection
{
	// Token: 0x0200018C RID: 396
	[Serializable]
	public sealed class AmbiguousMatchException : SystemException
	{
		// Token: 0x06001B5B RID: 7003 RVA: 0x0009D744 File Offset: 0x0009B944
		// Note: this type is marked as 'beforefieldinit'.
		static AmbiguousMatchException()
		{
			Il2CppClassPointerStore<AmbiguousMatchException>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection", "AmbiguousMatchException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AmbiguousMatchException>.NativeClassPtr);
			AmbiguousMatchException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmbiguousMatchException>.NativeClassPtr, 100667896);
			AmbiguousMatchException.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmbiguousMatchException>.NativeClassPtr, 100667897);
			AmbiguousMatchException.NativeMethodInfoPtr__ctor_Internal_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmbiguousMatchException>.NativeClassPtr, 100667898);
		}

		// Token: 0x06001B5C RID: 7004 RVA: 0x0009D7B0 File Offset: 0x0009B9B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 316814, XrefRangeEnd = 316819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AmbiguousMatchException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AmbiguousMatchException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmbiguousMatchException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B5D RID: 7005 RVA: 0x0009D7EC File Offset: 0x0009B9EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 316819, XrefRangeEnd = 316821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AmbiguousMatchException(string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AmbiguousMatchException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmbiguousMatchException.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001B5E RID: 7006 RVA: 0x0009D838 File Offset: 0x0009BA38
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 41353, RefRangeEnd = 41374, XrefRangeStart = 41353, XrefRangeEnd = 41374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AmbiguousMatchException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AmbiguousMatchException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmbiguousMatchException.NativeMethodInfoPtr__ctor_Internal_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B5F RID: 7007 RVA: 0x000096BE File Offset: 0x000078BE
		public AmbiguousMatchException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040018BE RID: 6334
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040018BF RID: 6335
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x040018C0 RID: 6336
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_SerializationInfo_StreamingContext_0;
	}
}
