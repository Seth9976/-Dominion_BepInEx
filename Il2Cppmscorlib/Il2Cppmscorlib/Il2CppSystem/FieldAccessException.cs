using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem
{
	// Token: 0x020000A5 RID: 165
	[Serializable]
	public class FieldAccessException : MemberAccessException
	{
		// Token: 0x06000BB4 RID: 2996 RVA: 0x00056C90 File Offset: 0x00054E90
		// Note: this type is marked as 'beforefieldinit'.
		static FieldAccessException()
		{
			Il2CppClassPointerStore<FieldAccessException>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "FieldAccessException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FieldAccessException>.NativeClassPtr);
			FieldAccessException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FieldAccessException>.NativeClassPtr, 100665262);
			FieldAccessException.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FieldAccessException>.NativeClassPtr, 100665263);
			FieldAccessException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FieldAccessException>.NativeClassPtr, 100665264);
		}

		// Token: 0x06000BB5 RID: 2997 RVA: 0x00056CFC File Offset: 0x00054EFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283559, XrefRangeEnd = 283563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FieldAccessException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FieldAccessException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FieldAccessException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BB6 RID: 2998 RVA: 0x00056D38 File Offset: 0x00054F38
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 283564, RefRangeEnd = 283565, XrefRangeStart = 283563, XrefRangeEnd = 283564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FieldAccessException(string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FieldAccessException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FieldAccessException.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000BB7 RID: 2999 RVA: 0x00056D84 File Offset: 0x00054F84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FieldAccessException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FieldAccessException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FieldAccessException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BB8 RID: 3000 RVA: 0x000050A4 File Offset: 0x000032A4
		public FieldAccessException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040009BA RID: 2490
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040009BB RID: 2491
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x040009BC RID: 2492
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;
	}
}
