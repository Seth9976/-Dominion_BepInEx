using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem
{
	// Token: 0x020000F5 RID: 245
	[Serializable]
	public class TimeZoneNotFoundException : Exception
	{
		// Token: 0x0600117F RID: 4479 RVA: 0x00072F10 File Offset: 0x00071110
		// Note: this type is marked as 'beforefieldinit'.
		static TimeZoneNotFoundException()
		{
			Il2CppClassPointerStore<TimeZoneNotFoundException>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "TimeZoneNotFoundException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TimeZoneNotFoundException>.NativeClassPtr);
			TimeZoneNotFoundException.NativeMethodInfoPtr__ctor_Public_Void_String_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneNotFoundException>.NativeClassPtr, 100666325);
			TimeZoneNotFoundException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneNotFoundException>.NativeClassPtr, 100666326);
			TimeZoneNotFoundException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneNotFoundException>.NativeClassPtr, 100666327);
		}

		// Token: 0x06001180 RID: 4480 RVA: 0x00072F7C File Offset: 0x0007117C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 300449, XrefRangeEnd = 300453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TimeZoneNotFoundException(string message, Exception innerException)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TimeZoneNotFoundException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(innerException);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneNotFoundException.NativeMethodInfoPtr__ctor_Public_Void_String_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001181 RID: 4481 RVA: 0x00072FDC File Offset: 0x000711DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 300453, XrefRangeEnd = 300457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TimeZoneNotFoundException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TimeZoneNotFoundException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneNotFoundException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001182 RID: 4482 RVA: 0x00073040 File Offset: 0x00071240
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 300461, RefRangeEnd = 300462, XrefRangeStart = 300457, XrefRangeEnd = 300461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TimeZoneNotFoundException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TimeZoneNotFoundException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneNotFoundException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001183 RID: 4483 RVA: 0x00006452 File Offset: 0x00004652
		public TimeZoneNotFoundException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000F21 RID: 3873
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Exception_0;

		// Token: 0x04000F22 RID: 3874
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04000F23 RID: 3875
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
