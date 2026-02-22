using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem
{
	// Token: 0x020000D0 RID: 208
	[Serializable]
	public class NotImplementedException : SystemException
	{
		// Token: 0x06000DED RID: 3565 RVA: 0x000613BC File Offset: 0x0005F5BC
		// Note: this type is marked as 'beforefieldinit'.
		static NotImplementedException()
		{
			Il2CppClassPointerStore<NotImplementedException>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "NotImplementedException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NotImplementedException>.NativeClassPtr);
			NotImplementedException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotImplementedException>.NativeClassPtr, 100665639);
			NotImplementedException.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotImplementedException>.NativeClassPtr, 100665640);
			NotImplementedException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotImplementedException>.NativeClassPtr, 100665641);
		}

		// Token: 0x06000DEE RID: 3566 RVA: 0x00061428 File Offset: 0x0005F628
		[CallerCount(60)]
		[CachedScanResults(RefRangeStart = 288540, RefRangeEnd = 288600, XrefRangeStart = 288535, XrefRangeEnd = 288540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NotImplementedException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NotImplementedException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NotImplementedException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DEF RID: 3567 RVA: 0x00061464 File Offset: 0x0005F664
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 288602, RefRangeEnd = 288606, XrefRangeStart = 288600, XrefRangeEnd = 288602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NotImplementedException(string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NotImplementedException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NotImplementedException.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000DF0 RID: 3568 RVA: 0x000614B0 File Offset: 0x0005F6B0
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 41353, RefRangeEnd = 41374, XrefRangeStart = 41353, XrefRangeEnd = 41374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NotImplementedException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NotImplementedException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NotImplementedException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DF1 RID: 3569 RVA: 0x000059D5 File Offset: 0x00003BD5
		public NotImplementedException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000BD6 RID: 3030
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000BD7 RID: 3031
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04000BD8 RID: 3032
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;
	}
}
