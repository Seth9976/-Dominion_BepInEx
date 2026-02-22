using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem
{
	// Token: 0x0200009B RID: 155
	[Serializable]
	public class DllNotFoundException : TypeLoadException
	{
		// Token: 0x06000AD9 RID: 2777 RVA: 0x00053218 File Offset: 0x00051418
		// Note: this type is marked as 'beforefieldinit'.
		static DllNotFoundException()
		{
			Il2CppClassPointerStore<DllNotFoundException>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "DllNotFoundException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DllNotFoundException>.NativeClassPtr);
			DllNotFoundException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DllNotFoundException>.NativeClassPtr, 100665114);
			DllNotFoundException.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DllNotFoundException>.NativeClassPtr, 100665115);
			DllNotFoundException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DllNotFoundException>.NativeClassPtr, 100665116);
		}

		// Token: 0x06000ADA RID: 2778 RVA: 0x00053284 File Offset: 0x00051484
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281890, XrefRangeEnd = 281895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DllNotFoundException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DllNotFoundException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DllNotFoundException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000ADB RID: 2779 RVA: 0x000532C0 File Offset: 0x000514C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281895, XrefRangeEnd = 281897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DllNotFoundException(string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DllNotFoundException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DllNotFoundException.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000ADC RID: 2780 RVA: 0x0005330C File Offset: 0x0005150C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281897, XrefRangeEnd = 281898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DllNotFoundException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DllNotFoundException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DllNotFoundException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000ADD RID: 2781 RVA: 0x00004D57 File Offset: 0x00002F57
		public DllNotFoundException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000913 RID: 2323
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000914 RID: 2324
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04000915 RID: 2325
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;
	}
}
