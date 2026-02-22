using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem
{
	// Token: 0x020000CD RID: 205
	[Serializable]
	public class MissingMethodException : MissingMemberException
	{
		// Token: 0x06000DDB RID: 3547 RVA: 0x00060F30 File Offset: 0x0005F130
		// Note: this type is marked as 'beforefieldinit'.
		static MissingMethodException()
		{
			Il2CppClassPointerStore<MissingMethodException>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "MissingMethodException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MissingMethodException>.NativeClassPtr);
			MissingMethodException.NativeFieldInfoPtr_signature = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MissingMethodException>.NativeClassPtr, "signature");
			MissingMethodException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MissingMethodException>.NativeClassPtr, 100665629);
			MissingMethodException.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MissingMethodException>.NativeClassPtr, 100665630);
			MissingMethodException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MissingMethodException>.NativeClassPtr, 100665631);
			MissingMethodException.NativeMethodInfoPtr_get_Message_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MissingMethodException>.NativeClassPtr, 100665632);
			MissingMethodException.NativeMethodInfoPtr__ctor_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MissingMethodException>.NativeClassPtr, 100665633);
			MissingMethodException.NativeMethodInfoPtr__ctor_Private_Void_String_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MissingMethodException>.NativeClassPtr, 100665634);
		}

		// Token: 0x06000DDC RID: 3548 RVA: 0x00060FEC File Offset: 0x0005F1EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288501, XrefRangeEnd = 288507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MissingMethodException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MissingMethodException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MissingMethodException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DDD RID: 3549 RVA: 0x00061028 File Offset: 0x0005F228
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 288510, RefRangeEnd = 288512, XrefRangeStart = 288507, XrefRangeEnd = 288510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MissingMethodException(string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MissingMethodException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MissingMethodException.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000DDE RID: 3550 RVA: 0x00061074 File Offset: 0x0005F274
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MissingMethodException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MissingMethodException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MissingMethodException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000282 RID: 642
		// (get) Token: 0x06000DDF RID: 3551 RVA: 0x000610D8 File Offset: 0x0005F2D8
		public unsafe override string Message
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288512, XrefRangeEnd = 288525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MissingMethodException.NativeMethodInfoPtr_get_Message_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000DE0 RID: 3552 RVA: 0x0006111C File Offset: 0x0005F31C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MissingMethodException(string className, string methodName)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MissingMethodException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(className);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(methodName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MissingMethodException.NativeMethodInfoPtr__ctor_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DE1 RID: 3553 RVA: 0x0006117C File Offset: 0x0005F37C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288525, XrefRangeEnd = 288527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MissingMethodException(string className, string methodName, string signature, string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MissingMethodException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(className);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(methodName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(signature);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MissingMethodException.NativeMethodInfoPtr__ctor_Private_Void_String_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DE2 RID: 3554 RVA: 0x00005962 File Offset: 0x00003B62
		public MissingMethodException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000281 RID: 641
		// (get) Token: 0x06000DE3 RID: 3555 RVA: 0x00061200 File Offset: 0x0005F400
		// (set) Token: 0x06000DE4 RID: 3556 RVA: 0x0000596B File Offset: 0x00003B6B
		public unsafe string signature
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MissingMethodException.NativeFieldInfoPtr_signature);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MissingMethodException.NativeFieldInfoPtr_signature), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000BCB RID: 3019
		private static readonly IntPtr NativeFieldInfoPtr_signature;

		// Token: 0x04000BCC RID: 3020
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000BCD RID: 3021
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04000BCE RID: 3022
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04000BCF RID: 3023
		private static readonly IntPtr NativeMethodInfoPtr_get_Message_Public_Virtual_get_String_0;

		// Token: 0x04000BD0 RID: 3024
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_0;

		// Token: 0x04000BD1 RID: 3025
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_String_String_String_String_0;
	}
}
