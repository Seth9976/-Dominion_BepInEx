using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem
{
	// Token: 0x020000F1 RID: 241
	[Serializable]
	public class TimeoutException : SystemException
	{
		// Token: 0x060010AB RID: 4267 RVA: 0x0006F610 File Offset: 0x0006D810
		// Note: this type is marked as 'beforefieldinit'.
		static TimeoutException()
		{
			Il2CppClassPointerStore<TimeoutException>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "TimeoutException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TimeoutException>.NativeClassPtr);
			TimeoutException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeoutException>.NativeClassPtr, 100666162);
			TimeoutException.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeoutException>.NativeClassPtr, 100666163);
			TimeoutException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeoutException>.NativeClassPtr, 100666164);
		}

		// Token: 0x060010AC RID: 4268 RVA: 0x0006F67C File Offset: 0x0006D87C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 298350, RefRangeEnd = 298351, XrefRangeStart = 298345, XrefRangeEnd = 298350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TimeoutException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TimeoutException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeoutException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010AD RID: 4269 RVA: 0x0006F6B8 File Offset: 0x0006D8B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 298353, RefRangeEnd = 298354, XrefRangeStart = 298351, XrefRangeEnd = 298353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TimeoutException(string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TimeoutException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeoutException.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060010AE RID: 4270 RVA: 0x0006F704 File Offset: 0x0006D904
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 41353, RefRangeEnd = 41374, XrefRangeStart = 41353, XrefRangeEnd = 41374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TimeoutException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TimeoutException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeoutException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010AF RID: 4271 RVA: 0x00006174 File Offset: 0x00004374
		public TimeoutException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000E75 RID: 3701
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000E76 RID: 3702
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04000E77 RID: 3703
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;
	}
}
