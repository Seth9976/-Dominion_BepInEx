using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem
{
	// Token: 0x020000D2 RID: 210
	[Serializable]
	public class NullReferenceException : SystemException
	{
		// Token: 0x06000DF8 RID: 3576 RVA: 0x000616E0 File Offset: 0x0005F8E0
		// Note: this type is marked as 'beforefieldinit'.
		static NullReferenceException()
		{
			Il2CppClassPointerStore<NullReferenceException>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "NullReferenceException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NullReferenceException>.NativeClassPtr);
			NullReferenceException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NullReferenceException>.NativeClassPtr, 100665646);
			NullReferenceException.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NullReferenceException>.NativeClassPtr, 100665647);
			NullReferenceException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NullReferenceException>.NativeClassPtr, 100665648);
		}

		// Token: 0x06000DF9 RID: 3577 RVA: 0x0006174C File Offset: 0x0005F94C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 289734, RefRangeEnd = 289738, XrefRangeStart = 289729, XrefRangeEnd = 289734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NullReferenceException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NullReferenceException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NullReferenceException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DFA RID: 3578 RVA: 0x00061788 File Offset: 0x0005F988
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 289740, RefRangeEnd = 289746, XrefRangeStart = 289738, XrefRangeEnd = 289740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NullReferenceException(string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NullReferenceException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NullReferenceException.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000DFB RID: 3579 RVA: 0x000617D4 File Offset: 0x0005F9D4
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 41353, RefRangeEnd = 41374, XrefRangeStart = 41353, XrefRangeEnd = 41374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NullReferenceException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NullReferenceException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NullReferenceException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DFC RID: 3580 RVA: 0x000059E7 File Offset: 0x00003BE7
		public NullReferenceException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000BDD RID: 3037
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000BDE RID: 3038
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04000BDF RID: 3039
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;
	}
}
