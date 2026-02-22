using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem
{
	// Token: 0x020000CB RID: 203
	[Serializable]
	public class MissingFieldException : MissingMemberException
	{
		// Token: 0x06000DC6 RID: 3526 RVA: 0x000609D8 File Offset: 0x0005EBD8
		// Note: this type is marked as 'beforefieldinit'.
		static MissingFieldException()
		{
			Il2CppClassPointerStore<MissingFieldException>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "MissingFieldException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MissingFieldException>.NativeClassPtr);
			MissingFieldException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MissingFieldException>.NativeClassPtr, 100665618);
			MissingFieldException.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MissingFieldException>.NativeClassPtr, 100665619);
			MissingFieldException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MissingFieldException>.NativeClassPtr, 100665620);
			MissingFieldException.NativeMethodInfoPtr_get_Message_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MissingFieldException>.NativeClassPtr, 100665621);
			MissingFieldException.NativeMethodInfoPtr__ctor_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MissingFieldException>.NativeClassPtr, 100665622);
		}

		// Token: 0x06000DC7 RID: 3527 RVA: 0x00060A6C File Offset: 0x0005EC6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288390, XrefRangeEnd = 288396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MissingFieldException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MissingFieldException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MissingFieldException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DC8 RID: 3528 RVA: 0x00060AA8 File Offset: 0x0005ECA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288396, XrefRangeEnd = 288399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MissingFieldException(string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MissingFieldException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MissingFieldException.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000DC9 RID: 3529 RVA: 0x00060AF4 File Offset: 0x0005ECF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288399, XrefRangeEnd = 288400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MissingFieldException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MissingFieldException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MissingFieldException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700027C RID: 636
		// (get) Token: 0x06000DCA RID: 3530 RVA: 0x00060B58 File Offset: 0x0005ED58
		public unsafe override string Message
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288400, XrefRangeEnd = 288423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MissingFieldException.NativeMethodInfoPtr_get_Message_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000DCB RID: 3531 RVA: 0x00060B9C File Offset: 0x0005ED9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288423, XrefRangeEnd = 288428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MissingFieldException(string className, string fieldName)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MissingFieldException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(className);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(fieldName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MissingFieldException.NativeMethodInfoPtr__ctor_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DCC RID: 3532 RVA: 0x000058F3 File Offset: 0x00003AF3
		public MissingFieldException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000BBD RID: 3005
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000BBE RID: 3006
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04000BBF RID: 3007
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04000BC0 RID: 3008
		private static readonly IntPtr NativeMethodInfoPtr_get_Message_Public_Virtual_get_String_0;

		// Token: 0x04000BC1 RID: 3009
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_0;
	}
}
