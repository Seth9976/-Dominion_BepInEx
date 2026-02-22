using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem
{
	// Token: 0x020000DB RID: 219
	[Serializable]
	public class PlatformNotSupportedException : NotSupportedException
	{
		// Token: 0x06000E6B RID: 3691 RVA: 0x00063A34 File Offset: 0x00061C34
		// Note: this type is marked as 'beforefieldinit'.
		static PlatformNotSupportedException()
		{
			Il2CppClassPointerStore<PlatformNotSupportedException>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "PlatformNotSupportedException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlatformNotSupportedException>.NativeClassPtr);
			PlatformNotSupportedException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformNotSupportedException>.NativeClassPtr, 100665724);
			PlatformNotSupportedException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformNotSupportedException>.NativeClassPtr, 100665725);
		}

		// Token: 0x06000E6C RID: 3692 RVA: 0x00063A8C File Offset: 0x00061C8C
		[CallerCount(56)]
		[CachedScanResults(RefRangeStart = 290363, RefRangeEnd = 290419, XrefRangeStart = 290358, XrefRangeEnd = 290363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlatformNotSupportedException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlatformNotSupportedException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformNotSupportedException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E6D RID: 3693 RVA: 0x00063AC8 File Offset: 0x00061CC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlatformNotSupportedException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlatformNotSupportedException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformNotSupportedException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E6E RID: 3694 RVA: 0x00005BBC File Offset: 0x00003DBC
		public PlatformNotSupportedException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000C32 RID: 3122
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000C33 RID: 3123
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;
	}
}
