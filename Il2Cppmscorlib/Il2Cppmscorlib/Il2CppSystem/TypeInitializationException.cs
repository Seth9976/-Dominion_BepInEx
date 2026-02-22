using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem
{
	// Token: 0x020000F8 RID: 248
	[Serializable]
	public sealed class TypeInitializationException : SystemException
	{
		// Token: 0x06001224 RID: 4644 RVA: 0x0007685C File Offset: 0x00074A5C
		// Note: this type is marked as 'beforefieldinit'.
		static TypeInitializationException()
		{
			Il2CppClassPointerStore<TypeInitializationException>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "TypeInitializationException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TypeInitializationException>.NativeClassPtr);
			TypeInitializationException.NativeFieldInfoPtr__typeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeInitializationException>.NativeClassPtr, "_typeName");
			TypeInitializationException.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeInitializationException>.NativeClassPtr, 100666464);
			TypeInitializationException.NativeMethodInfoPtr__ctor_Public_Void_String_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeInitializationException>.NativeClassPtr, 100666465);
			TypeInitializationException.NativeMethodInfoPtr__ctor_Internal_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeInitializationException>.NativeClassPtr, 100666466);
			TypeInitializationException.NativeMethodInfoPtr_get_TypeName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeInitializationException>.NativeClassPtr, 100666467);
			TypeInitializationException.NativeMethodInfoPtr_GetObjectData_Public_Virtual_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeInitializationException>.NativeClassPtr, 100666468);
		}

		// Token: 0x06001225 RID: 4645 RVA: 0x00076904 File Offset: 0x00074B04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 302591, XrefRangeEnd = 302596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TypeInitializationException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TypeInitializationException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeInitializationException.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001226 RID: 4646 RVA: 0x00076940 File Offset: 0x00074B40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 302596, XrefRangeEnd = 302610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TypeInitializationException(string fullTypeName, Exception innerException)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TypeInitializationException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(fullTypeName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(innerException);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeInitializationException.NativeMethodInfoPtr__ctor_Public_Void_String_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001227 RID: 4647 RVA: 0x000769A0 File Offset: 0x00074BA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 302610, XrefRangeEnd = 302614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TypeInitializationException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TypeInitializationException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeInitializationException.NativeMethodInfoPtr__ctor_Internal_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000354 RID: 852
		// (get) Token: 0x06001228 RID: 4648 RVA: 0x00076A04 File Offset: 0x00074C04
		public unsafe string TypeName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 302614, XrefRangeEnd = 302616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeInitializationException.NativeMethodInfoPtr_get_TypeName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001229 RID: 4649 RVA: 0x00076A3C File Offset: 0x00074C3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 302616, XrefRangeEnd = 302628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeInitializationException.NativeMethodInfoPtr_GetObjectData_Public_Virtual_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600122A RID: 4650 RVA: 0x00006535 File Offset: 0x00004735
		public TypeInitializationException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000353 RID: 851
		// (get) Token: 0x0600122B RID: 4651 RVA: 0x00076A98 File Offset: 0x00074C98
		// (set) Token: 0x0600122C RID: 4652 RVA: 0x0000653E File Offset: 0x0000473E
		public unsafe string _typeName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeInitializationException.NativeFieldInfoPtr__typeName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeInitializationException.NativeFieldInfoPtr__typeName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000FBB RID: 4027
		private static readonly IntPtr NativeFieldInfoPtr__typeName;

		// Token: 0x04000FBC RID: 4028
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x04000FBD RID: 4029
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Exception_0;

		// Token: 0x04000FBE RID: 4030
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04000FBF RID: 4031
		private static readonly IntPtr NativeMethodInfoPtr_get_TypeName_Public_get_String_0;

		// Token: 0x04000FC0 RID: 4032
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectData_Public_Virtual_Void_SerializationInfo_StreamingContext_0;
	}
}
