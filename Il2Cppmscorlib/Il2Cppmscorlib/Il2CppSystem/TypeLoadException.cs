using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem
{
	// Token: 0x020000F9 RID: 249
	[Serializable]
	public class TypeLoadException : SystemException
	{
		// Token: 0x0600122D RID: 4653 RVA: 0x00076AC0 File Offset: 0x00074CC0
		// Note: this type is marked as 'beforefieldinit'.
		static TypeLoadException()
		{
			Il2CppClassPointerStore<TypeLoadException>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "TypeLoadException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TypeLoadException>.NativeClassPtr);
			TypeLoadException.NativeFieldInfoPtr_ClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeLoadException>.NativeClassPtr, "ClassName");
			TypeLoadException.NativeFieldInfoPtr_AssemblyName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeLoadException>.NativeClassPtr, "AssemblyName");
			TypeLoadException.NativeFieldInfoPtr_MessageArg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeLoadException>.NativeClassPtr, "MessageArg");
			TypeLoadException.NativeFieldInfoPtr_ResourceId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeLoadException>.NativeClassPtr, "ResourceId");
			TypeLoadException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeLoadException>.NativeClassPtr, 100666469);
			TypeLoadException.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeLoadException>.NativeClassPtr, 100666470);
			TypeLoadException.NativeMethodInfoPtr_get_Message_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeLoadException>.NativeClassPtr, 100666471);
			TypeLoadException.NativeMethodInfoPtr_SetMessageField_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeLoadException>.NativeClassPtr, 100666472);
			TypeLoadException.NativeMethodInfoPtr__ctor_Private_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeLoadException>.NativeClassPtr, 100666473);
			TypeLoadException.NativeMethodInfoPtr__ctor_Private_Void_String_String_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeLoadException>.NativeClassPtr, 100666474);
			TypeLoadException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeLoadException>.NativeClassPtr, 100666475);
			TypeLoadException.NativeMethodInfoPtr_GetObjectData_Public_Virtual_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeLoadException>.NativeClassPtr, 100666476);
		}

		// Token: 0x0600122E RID: 4654 RVA: 0x00076BE0 File Offset: 0x00074DE0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 302633, RefRangeEnd = 302635, XrefRangeStart = 302628, XrefRangeEnd = 302633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TypeLoadException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TypeLoadException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeLoadException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600122F RID: 4655 RVA: 0x00076C1C File Offset: 0x00074E1C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 302637, RefRangeEnd = 302642, XrefRangeStart = 302635, XrefRangeEnd = 302637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TypeLoadException(string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TypeLoadException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeLoadException.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000359 RID: 857
		// (get) Token: 0x06001230 RID: 4656 RVA: 0x00076C68 File Offset: 0x00074E68
		public unsafe override string Message
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 302642, XrefRangeEnd = 302643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TypeLoadException.NativeMethodInfoPtr_get_Message_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001231 RID: 4657 RVA: 0x00076CAC File Offset: 0x00074EAC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 302649, RefRangeEnd = 302652, XrefRangeStart = 302643, XrefRangeEnd = 302649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMessageField()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeLoadException.NativeMethodInfoPtr_SetMessageField_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001232 RID: 4658 RVA: 0x00076CE0 File Offset: 0x00074EE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 302652, XrefRangeEnd = 302655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TypeLoadException(string className, string assemblyName)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TypeLoadException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(className);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(assemblyName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeLoadException.NativeMethodInfoPtr__ctor_Private_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001233 RID: 4659 RVA: 0x00076D40 File Offset: 0x00074F40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 302655, XrefRangeEnd = 302658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TypeLoadException(string className, string assemblyName, string messageArg, int resourceId)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TypeLoadException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(className);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(assemblyName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(messageArg);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref resourceId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeLoadException.NativeMethodInfoPtr__ctor_Private_Void_String_String_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001234 RID: 4660 RVA: 0x00076DC0 File Offset: 0x00074FC0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 302671, RefRangeEnd = 302673, XrefRangeStart = 302658, XrefRangeEnd = 302671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TypeLoadException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TypeLoadException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeLoadException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001235 RID: 4661 RVA: 0x00076E24 File Offset: 0x00075024
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 302673, XrefRangeEnd = 302702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TypeLoadException.NativeMethodInfoPtr_GetObjectData_Public_Virtual_Void_SerializationInfo_StreamingContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001236 RID: 4662 RVA: 0x0000655D File Offset: 0x0000475D
		public TypeLoadException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000355 RID: 853
		// (get) Token: 0x06001237 RID: 4663 RVA: 0x00076E88 File Offset: 0x00075088
		// (set) Token: 0x06001238 RID: 4664 RVA: 0x00006566 File Offset: 0x00004766
		public unsafe string ClassName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeLoadException.NativeFieldInfoPtr_ClassName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeLoadException.NativeFieldInfoPtr_ClassName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000356 RID: 854
		// (get) Token: 0x06001239 RID: 4665 RVA: 0x00076EB0 File Offset: 0x000750B0
		// (set) Token: 0x0600123A RID: 4666 RVA: 0x00006585 File Offset: 0x00004785
		public unsafe string AssemblyName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeLoadException.NativeFieldInfoPtr_AssemblyName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeLoadException.NativeFieldInfoPtr_AssemblyName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000357 RID: 855
		// (get) Token: 0x0600123B RID: 4667 RVA: 0x00076ED8 File Offset: 0x000750D8
		// (set) Token: 0x0600123C RID: 4668 RVA: 0x000065A4 File Offset: 0x000047A4
		public unsafe string MessageArg
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeLoadException.NativeFieldInfoPtr_MessageArg);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeLoadException.NativeFieldInfoPtr_MessageArg), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000358 RID: 856
		// (get) Token: 0x0600123D RID: 4669 RVA: 0x00076F00 File Offset: 0x00075100
		// (set) Token: 0x0600123E RID: 4670 RVA: 0x000065C3 File Offset: 0x000047C3
		public unsafe int ResourceId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeLoadException.NativeFieldInfoPtr_ResourceId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeLoadException.NativeFieldInfoPtr_ResourceId)) = value;
			}
		}

		// Token: 0x04000FC1 RID: 4033
		private static readonly IntPtr NativeFieldInfoPtr_ClassName;

		// Token: 0x04000FC2 RID: 4034
		private static readonly IntPtr NativeFieldInfoPtr_AssemblyName;

		// Token: 0x04000FC3 RID: 4035
		private static readonly IntPtr NativeFieldInfoPtr_MessageArg;

		// Token: 0x04000FC4 RID: 4036
		private static readonly IntPtr NativeFieldInfoPtr_ResourceId;

		// Token: 0x04000FC5 RID: 4037
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000FC6 RID: 4038
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04000FC7 RID: 4039
		private static readonly IntPtr NativeMethodInfoPtr_get_Message_Public_Virtual_get_String_0;

		// Token: 0x04000FC8 RID: 4040
		private static readonly IntPtr NativeMethodInfoPtr_SetMessageField_Private_Void_0;

		// Token: 0x04000FC9 RID: 4041
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_String_String_0;

		// Token: 0x04000FCA RID: 4042
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_String_String_String_Int32_0;

		// Token: 0x04000FCB RID: 4043
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04000FCC RID: 4044
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectData_Public_Virtual_Void_SerializationInfo_StreamingContext_0;
	}
}
