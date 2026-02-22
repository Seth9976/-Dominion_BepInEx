using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x02000379 RID: 889
	public sealed class WriteObjectInfo : Object
	{
		// Token: 0x0600389E RID: 14494 RVA: 0x0010F378 File Offset: 0x0010D578
		// Note: this type is marked as 'beforefieldinit'.
		static WriteObjectInfo()
		{
			Il2CppClassPointerStore<WriteObjectInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization.Formatters.Binary", "WriteObjectInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WriteObjectInfo>.NativeClassPtr);
			WriteObjectInfo.NativeFieldInfoPtr_objectInfoId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WriteObjectInfo>.NativeClassPtr, "objectInfoId");
			WriteObjectInfo.NativeFieldInfoPtr_obj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WriteObjectInfo>.NativeClassPtr, "obj");
			WriteObjectInfo.NativeFieldInfoPtr_objectType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WriteObjectInfo>.NativeClassPtr, "objectType");
			WriteObjectInfo.NativeFieldInfoPtr_isSi = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WriteObjectInfo>.NativeClassPtr, "isSi");
			WriteObjectInfo.NativeFieldInfoPtr_isNamed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WriteObjectInfo>.NativeClassPtr, "isNamed");
			WriteObjectInfo.NativeFieldInfoPtr_isTyped = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WriteObjectInfo>.NativeClassPtr, "isTyped");
			WriteObjectInfo.NativeFieldInfoPtr_isArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WriteObjectInfo>.NativeClassPtr, "isArray");
			WriteObjectInfo.NativeFieldInfoPtr_si = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WriteObjectInfo>.NativeClassPtr, "si");
			WriteObjectInfo.NativeFieldInfoPtr_cache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WriteObjectInfo>.NativeClassPtr, "cache");
			WriteObjectInfo.NativeFieldInfoPtr_memberData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WriteObjectInfo>.NativeClassPtr, "memberData");
			WriteObjectInfo.NativeFieldInfoPtr_serializationSurrogate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WriteObjectInfo>.NativeClassPtr, "serializationSurrogate");
			WriteObjectInfo.NativeFieldInfoPtr_context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WriteObjectInfo>.NativeClassPtr, "context");
			WriteObjectInfo.NativeFieldInfoPtr_serObjectInfoInit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WriteObjectInfo>.NativeClassPtr, "serObjectInfoInit");
			WriteObjectInfo.NativeFieldInfoPtr_objectId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WriteObjectInfo>.NativeClassPtr, "objectId");
			WriteObjectInfo.NativeFieldInfoPtr_assemId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WriteObjectInfo>.NativeClassPtr, "assemId");
			WriteObjectInfo.NativeFieldInfoPtr_binderTypeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WriteObjectInfo>.NativeClassPtr, "binderTypeName");
			WriteObjectInfo.NativeFieldInfoPtr_binderAssemblyString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WriteObjectInfo>.NativeClassPtr, "binderAssemblyString");
			WriteObjectInfo.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WriteObjectInfo>.NativeClassPtr, 100671843);
			WriteObjectInfo.NativeMethodInfoPtr_ObjectEnd_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WriteObjectInfo>.NativeClassPtr, 100671844);
			WriteObjectInfo.NativeMethodInfoPtr_InternalInit_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WriteObjectInfo>.NativeClassPtr, 100671845);
			WriteObjectInfo.NativeMethodInfoPtr_Serialize_Internal_Static_WriteObjectInfo_Object_ISurrogateSelector_StreamingContext_SerObjectInfoInit_IFormatterConverter_ObjectWriter_SerializationBinder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WriteObjectInfo>.NativeClassPtr, 100671846);
			WriteObjectInfo.NativeMethodInfoPtr_InitSerialize_Internal_Void_Object_ISurrogateSelector_StreamingContext_SerObjectInfoInit_IFormatterConverter_ObjectWriter_SerializationBinder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WriteObjectInfo>.NativeClassPtr, 100671847);
			WriteObjectInfo.NativeMethodInfoPtr_Serialize_Internal_Static_WriteObjectInfo_Type_ISurrogateSelector_StreamingContext_SerObjectInfoInit_IFormatterConverter_SerializationBinder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WriteObjectInfo>.NativeClassPtr, 100671848);
			WriteObjectInfo.NativeMethodInfoPtr_InitSerialize_Internal_Void_Type_ISurrogateSelector_StreamingContext_SerObjectInfoInit_IFormatterConverter_SerializationBinder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WriteObjectInfo>.NativeClassPtr, 100671849);
			WriteObjectInfo.NativeMethodInfoPtr_InitSiWrite_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WriteObjectInfo>.NativeClassPtr, 100671850);
			WriteObjectInfo.NativeMethodInfoPtr_CheckTypeForwardedFrom_Private_Static_Void_SerObjectInfoCache_Type_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WriteObjectInfo>.NativeClassPtr, 100671851);
			WriteObjectInfo.NativeMethodInfoPtr_InitNoMembers_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WriteObjectInfo>.NativeClassPtr, 100671852);
			WriteObjectInfo.NativeMethodInfoPtr_InitMemberInfo_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WriteObjectInfo>.NativeClassPtr, 100671853);
			WriteObjectInfo.NativeMethodInfoPtr_GetTypeFullName_Internal_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WriteObjectInfo>.NativeClassPtr, 100671854);
			WriteObjectInfo.NativeMethodInfoPtr_GetAssemblyString_Internal_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WriteObjectInfo>.NativeClassPtr, 100671855);
			WriteObjectInfo.NativeMethodInfoPtr_InvokeSerializationBinder_Private_Void_SerializationBinder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WriteObjectInfo>.NativeClassPtr, 100671856);
			WriteObjectInfo.NativeMethodInfoPtr_GetMemberType_Internal_Type_MemberInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WriteObjectInfo>.NativeClassPtr, 100671857);
			WriteObjectInfo.NativeMethodInfoPtr_GetMemberInfo_Internal_Void_byref_Il2CppStringArray_byref_Il2CppReferenceArray_1_Type_byref_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WriteObjectInfo>.NativeClassPtr, 100671858);
			WriteObjectInfo.NativeMethodInfoPtr_GetObjectInfo_Private_Static_WriteObjectInfo_SerObjectInfoInit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WriteObjectInfo>.NativeClassPtr, 100671859);
			WriteObjectInfo.NativeMethodInfoPtr_PutObjectInfo_Private_Static_Void_SerObjectInfoInit_WriteObjectInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WriteObjectInfo>.NativeClassPtr, 100671860);
		}

		// Token: 0x0600389F RID: 14495 RVA: 0x0010F664 File Offset: 0x0010D864
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WriteObjectInfo()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WriteObjectInfo>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WriteObjectInfo.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038A0 RID: 14496 RVA: 0x0010F6A0 File Offset: 0x0010D8A0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 346140, RefRangeEnd = 346142, XrefRangeStart = 346138, XrefRangeEnd = 346140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ObjectEnd()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WriteObjectInfo.NativeMethodInfoPtr_ObjectEnd_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038A1 RID: 14497 RVA: 0x0010F6D4 File Offset: 0x0010D8D4
		[CallerCount(0)]
		public unsafe void InternalInit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WriteObjectInfo.NativeMethodInfoPtr_InternalInit_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038A2 RID: 14498 RVA: 0x0010F708 File Offset: 0x0010D908
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 346144, RefRangeEnd = 346146, XrefRangeStart = 346142, XrefRangeEnd = 346144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static WriteObjectInfo Serialize(Object obj, ISurrogateSelector surrogateSelector, StreamingContext context, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, ObjectWriter objectWriter, SerializationBinder binder)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(surrogateSelector);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(serObjectInfoInit);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(converter);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(objectWriter);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(binder);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WriteObjectInfo.NativeMethodInfoPtr_Serialize_Internal_Static_WriteObjectInfo_Object_ISurrogateSelector_StreamingContext_SerObjectInfoInit_IFormatterConverter_ObjectWriter_SerializationBinder_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<WriteObjectInfo>(intPtr3) : null;
		}

		// Token: 0x060038A3 RID: 14499 RVA: 0x0010F7C0 File Offset: 0x0010D9C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 346163, RefRangeEnd = 346164, XrefRangeStart = 346146, XrefRangeEnd = 346163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitSerialize(Object obj, ISurrogateSelector surrogateSelector, StreamingContext context, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, ObjectWriter objectWriter, SerializationBinder binder)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(surrogateSelector);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(serObjectInfoInit);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(converter);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(objectWriter);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(binder);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WriteObjectInfo.NativeMethodInfoPtr_InitSerialize_Internal_Void_Object_ISurrogateSelector_StreamingContext_SerObjectInfoInit_IFormatterConverter_ObjectWriter_SerializationBinder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038A4 RID: 14500 RVA: 0x0010F878 File Offset: 0x0010DA78
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 346166, RefRangeEnd = 346168, XrefRangeStart = 346164, XrefRangeEnd = 346166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static WriteObjectInfo Serialize(Type objectType, ISurrogateSelector surrogateSelector, StreamingContext context, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, SerializationBinder binder)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(objectType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(surrogateSelector);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(serObjectInfoInit);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(converter);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(binder);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WriteObjectInfo.NativeMethodInfoPtr_Serialize_Internal_Static_WriteObjectInfo_Type_ISurrogateSelector_StreamingContext_SerObjectInfoInit_IFormatterConverter_SerializationBinder_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<WriteObjectInfo>(intPtr3) : null;
		}

		// Token: 0x060038A5 RID: 14501 RVA: 0x0010F920 File Offset: 0x0010DB20
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 346213, RefRangeEnd = 346214, XrefRangeStart = 346168, XrefRangeEnd = 346213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitSerialize(Type objectType, ISurrogateSelector surrogateSelector, StreamingContext context, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, SerializationBinder binder)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(objectType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(surrogateSelector);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(serObjectInfoInit);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(converter);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(binder);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WriteObjectInfo.NativeMethodInfoPtr_InitSerialize_Internal_Void_Type_ISurrogateSelector_StreamingContext_SerObjectInfoInit_IFormatterConverter_SerializationBinder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038A6 RID: 14502 RVA: 0x0010F9C4 File Offset: 0x0010DBC4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 346244, RefRangeEnd = 346245, XrefRangeStart = 346214, XrefRangeEnd = 346244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitSiWrite()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WriteObjectInfo.NativeMethodInfoPtr_InitSiWrite_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038A7 RID: 14503 RVA: 0x0010F9F8 File Offset: 0x0010DBF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 346245, XrefRangeEnd = 346251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CheckTypeForwardedFrom(SerObjectInfoCache cache, Type objectType, string binderAssemblyString)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cache);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(objectType);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(binderAssemblyString);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WriteObjectInfo.NativeMethodInfoPtr_CheckTypeForwardedFrom_Private_Static_Void_SerObjectInfoCache_Type_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038A8 RID: 14504 RVA: 0x0010FA54 File Offset: 0x0010DC54
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 346256, RefRangeEnd = 346257, XrefRangeStart = 346251, XrefRangeEnd = 346256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitNoMembers()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WriteObjectInfo.NativeMethodInfoPtr_InitNoMembers_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038A9 RID: 14505 RVA: 0x0010FA88 File Offset: 0x0010DC88
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 346279, RefRangeEnd = 346280, XrefRangeStart = 346257, XrefRangeEnd = 346279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitMemberInfo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WriteObjectInfo.NativeMethodInfoPtr_InitMemberInfo_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038AA RID: 14506 RVA: 0x0010FABC File Offset: 0x0010DCBC
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 346280, RefRangeEnd = 346290, XrefRangeStart = 346280, XrefRangeEnd = 346280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetTypeFullName()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WriteObjectInfo.NativeMethodInfoPtr_GetTypeFullName_Internal_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060038AB RID: 14507 RVA: 0x0010FAF4 File Offset: 0x0010DCF4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 346290, RefRangeEnd = 346292, XrefRangeStart = 346290, XrefRangeEnd = 346290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetAssemblyString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WriteObjectInfo.NativeMethodInfoPtr_GetAssemblyString_Internal_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060038AC RID: 14508 RVA: 0x0010FB2C File Offset: 0x0010DD2C
		[CallerCount(0)]
		public unsafe void InvokeSerializationBinder(SerializationBinder binder)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(binder);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WriteObjectInfo.NativeMethodInfoPtr_InvokeSerializationBinder_Private_Void_SerializationBinder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060038AD RID: 14509 RVA: 0x0010FB70 File Offset: 0x0010DD70
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 346296, RefRangeEnd = 346297, XrefRangeStart = 346292, XrefRangeEnd = 346296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Type GetMemberType(MemberInfo objMember)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(objMember);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WriteObjectInfo.NativeMethodInfoPtr_GetMemberType_Internal_Type_MemberInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x060038AE RID: 14510 RVA: 0x0010FBC0 File Offset: 0x0010DDC0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 346297, RefRangeEnd = 346298, XrefRangeStart = 346297, XrefRangeEnd = 346297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetMemberInfo(out Il2CppStringArray outMemberNames, out Il2CppReferenceArray<Type> outMemberTypes, out Il2CppReferenceArray<Object> outMemberData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = 0;
				ptr2 = &intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			ref IntPtr ptr4 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr3 = 0;
			ptr4 = &intPtr3;
			IntPtr intPtr5;
			IntPtr intPtr4 = IL2CPP.il2cpp_runtime_invoke(WriteObjectInfo.NativeMethodInfoPtr_GetMemberInfo_Internal_Void_byref_Il2CppStringArray_byref_Il2CppReferenceArray_1_Type_byref_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr5);
			Il2CppException.RaiseExceptionIfNecessary(intPtr5);
			IntPtr intPtr6 = intPtr;
			outMemberNames = ((intPtr6 == 0) ? null : new Il2CppStringArray(intPtr6));
			IntPtr intPtr7 = intPtr2;
			outMemberTypes = ((intPtr7 == 0) ? null : new Il2CppReferenceArray<Type>(intPtr7));
			IntPtr intPtr8 = intPtr3;
			outMemberData = ((intPtr8 == 0) ? null : new Il2CppReferenceArray<Object>(intPtr8));
		}

		// Token: 0x060038AF RID: 14511 RVA: 0x0010FC58 File Offset: 0x0010DE58
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 346303, RefRangeEnd = 346305, XrefRangeStart = 346298, XrefRangeEnd = 346303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static WriteObjectInfo GetObjectInfo(SerObjectInfoInit serObjectInfoInit)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serObjectInfoInit);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WriteObjectInfo.NativeMethodInfoPtr_GetObjectInfo_Private_Static_WriteObjectInfo_SerObjectInfoInit_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WriteObjectInfo>(intPtr3) : null;
			}
		}

		// Token: 0x060038B0 RID: 14512 RVA: 0x0010FC9C File Offset: 0x0010DE9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 346305, XrefRangeEnd = 346307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void PutObjectInfo(SerObjectInfoInit serObjectInfoInit, WriteObjectInfo objectInfo)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serObjectInfoInit);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(objectInfo);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WriteObjectInfo.NativeMethodInfoPtr_PutObjectInfo_Private_Static_Void_SerObjectInfoInit_WriteObjectInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038B1 RID: 14513 RVA: 0x00014BA2 File Offset: 0x00012DA2
		public WriteObjectInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000DDF RID: 3551
		// (get) Token: 0x060038B2 RID: 14514 RVA: 0x0010FCE4 File Offset: 0x0010DEE4
		// (set) Token: 0x060038B3 RID: 14515 RVA: 0x00014BAB File Offset: 0x00012DAB
		public unsafe int objectInfoId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WriteObjectInfo.NativeFieldInfoPtr_objectInfoId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WriteObjectInfo.NativeFieldInfoPtr_objectInfoId)) = value;
			}
		}

		// Token: 0x17000DE0 RID: 3552
		// (get) Token: 0x060038B4 RID: 14516 RVA: 0x0010FD0C File Offset: 0x0010DF0C
		// (set) Token: 0x060038B5 RID: 14517 RVA: 0x00014BC6 File Offset: 0x00012DC6
		public unsafe Object obj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WriteObjectInfo.NativeFieldInfoPtr_obj);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WriteObjectInfo.NativeFieldInfoPtr_obj), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DE1 RID: 3553
		// (get) Token: 0x060038B6 RID: 14518 RVA: 0x0010FD3C File Offset: 0x0010DF3C
		// (set) Token: 0x060038B7 RID: 14519 RVA: 0x00014BE5 File Offset: 0x00012DE5
		public unsafe Type objectType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WriteObjectInfo.NativeFieldInfoPtr_objectType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WriteObjectInfo.NativeFieldInfoPtr_objectType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DE2 RID: 3554
		// (get) Token: 0x060038B8 RID: 14520 RVA: 0x0010FD6C File Offset: 0x0010DF6C
		// (set) Token: 0x060038B9 RID: 14521 RVA: 0x00014C04 File Offset: 0x00012E04
		public unsafe bool isSi
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WriteObjectInfo.NativeFieldInfoPtr_isSi);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WriteObjectInfo.NativeFieldInfoPtr_isSi)) = value;
			}
		}

		// Token: 0x17000DE3 RID: 3555
		// (get) Token: 0x060038BA RID: 14522 RVA: 0x0010FD94 File Offset: 0x0010DF94
		// (set) Token: 0x060038BB RID: 14523 RVA: 0x00014C1F File Offset: 0x00012E1F
		public unsafe bool isNamed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WriteObjectInfo.NativeFieldInfoPtr_isNamed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WriteObjectInfo.NativeFieldInfoPtr_isNamed)) = value;
			}
		}

		// Token: 0x17000DE4 RID: 3556
		// (get) Token: 0x060038BC RID: 14524 RVA: 0x0010FDBC File Offset: 0x0010DFBC
		// (set) Token: 0x060038BD RID: 14525 RVA: 0x00014C3A File Offset: 0x00012E3A
		public unsafe bool isTyped
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WriteObjectInfo.NativeFieldInfoPtr_isTyped);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WriteObjectInfo.NativeFieldInfoPtr_isTyped)) = value;
			}
		}

		// Token: 0x17000DE5 RID: 3557
		// (get) Token: 0x060038BE RID: 14526 RVA: 0x0010FDE4 File Offset: 0x0010DFE4
		// (set) Token: 0x060038BF RID: 14527 RVA: 0x00014C55 File Offset: 0x00012E55
		public unsafe bool isArray
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WriteObjectInfo.NativeFieldInfoPtr_isArray);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WriteObjectInfo.NativeFieldInfoPtr_isArray)) = value;
			}
		}

		// Token: 0x17000DE6 RID: 3558
		// (get) Token: 0x060038C0 RID: 14528 RVA: 0x0010FE0C File Offset: 0x0010E00C
		// (set) Token: 0x060038C1 RID: 14529 RVA: 0x00014C70 File Offset: 0x00012E70
		public unsafe SerializationInfo si
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WriteObjectInfo.NativeFieldInfoPtr_si);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerializationInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WriteObjectInfo.NativeFieldInfoPtr_si), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DE7 RID: 3559
		// (get) Token: 0x060038C2 RID: 14530 RVA: 0x0010FE3C File Offset: 0x0010E03C
		// (set) Token: 0x060038C3 RID: 14531 RVA: 0x00014C8F File Offset: 0x00012E8F
		public unsafe SerObjectInfoCache cache
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WriteObjectInfo.NativeFieldInfoPtr_cache);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerObjectInfoCache>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WriteObjectInfo.NativeFieldInfoPtr_cache), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DE8 RID: 3560
		// (get) Token: 0x060038C4 RID: 14532 RVA: 0x0010FE6C File Offset: 0x0010E06C
		// (set) Token: 0x060038C5 RID: 14533 RVA: 0x00014CAE File Offset: 0x00012EAE
		public unsafe Il2CppReferenceArray<Object> memberData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WriteObjectInfo.NativeFieldInfoPtr_memberData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WriteObjectInfo.NativeFieldInfoPtr_memberData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DE9 RID: 3561
		// (get) Token: 0x060038C6 RID: 14534 RVA: 0x0010FE9C File Offset: 0x0010E09C
		// (set) Token: 0x060038C7 RID: 14535 RVA: 0x00014CCD File Offset: 0x00012ECD
		public unsafe ISerializationSurrogate serializationSurrogate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WriteObjectInfo.NativeFieldInfoPtr_serializationSurrogate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ISerializationSurrogate>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WriteObjectInfo.NativeFieldInfoPtr_serializationSurrogate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DEA RID: 3562
		// (get) Token: 0x060038C8 RID: 14536 RVA: 0x0010FECC File Offset: 0x0010E0CC
		// (set) Token: 0x060038C9 RID: 14537 RVA: 0x00014CEC File Offset: 0x00012EEC
		public StreamingContext context
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WriteObjectInfo.NativeFieldInfoPtr_context);
				return new StreamingContext(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StreamingContext>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WriteObjectInfo.NativeFieldInfoPtr_context), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<StreamingContext>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000DEB RID: 3563
		// (get) Token: 0x060038CA RID: 14538 RVA: 0x0010FEFC File Offset: 0x0010E0FC
		// (set) Token: 0x060038CB RID: 14539 RVA: 0x00014D1A File Offset: 0x00012F1A
		public unsafe SerObjectInfoInit serObjectInfoInit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WriteObjectInfo.NativeFieldInfoPtr_serObjectInfoInit);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerObjectInfoInit>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WriteObjectInfo.NativeFieldInfoPtr_serObjectInfoInit), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DEC RID: 3564
		// (get) Token: 0x060038CC RID: 14540 RVA: 0x0010FF2C File Offset: 0x0010E12C
		// (set) Token: 0x060038CD RID: 14541 RVA: 0x00014D39 File Offset: 0x00012F39
		public unsafe long objectId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WriteObjectInfo.NativeFieldInfoPtr_objectId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WriteObjectInfo.NativeFieldInfoPtr_objectId)) = value;
			}
		}

		// Token: 0x17000DED RID: 3565
		// (get) Token: 0x060038CE RID: 14542 RVA: 0x0010FF54 File Offset: 0x0010E154
		// (set) Token: 0x060038CF RID: 14543 RVA: 0x00014D54 File Offset: 0x00012F54
		public unsafe long assemId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WriteObjectInfo.NativeFieldInfoPtr_assemId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WriteObjectInfo.NativeFieldInfoPtr_assemId)) = value;
			}
		}

		// Token: 0x17000DEE RID: 3566
		// (get) Token: 0x060038D0 RID: 14544 RVA: 0x0010FF7C File Offset: 0x0010E17C
		// (set) Token: 0x060038D1 RID: 14545 RVA: 0x00014D6F File Offset: 0x00012F6F
		public unsafe string binderTypeName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WriteObjectInfo.NativeFieldInfoPtr_binderTypeName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WriteObjectInfo.NativeFieldInfoPtr_binderTypeName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000DEF RID: 3567
		// (get) Token: 0x060038D2 RID: 14546 RVA: 0x0010FFA4 File Offset: 0x0010E1A4
		// (set) Token: 0x060038D3 RID: 14547 RVA: 0x00014D8E File Offset: 0x00012F8E
		public unsafe string binderAssemblyString
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WriteObjectInfo.NativeFieldInfoPtr_binderAssemblyString);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WriteObjectInfo.NativeFieldInfoPtr_binderAssemblyString), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04002FB2 RID: 12210
		private static readonly IntPtr NativeFieldInfoPtr_objectInfoId;

		// Token: 0x04002FB3 RID: 12211
		private static readonly IntPtr NativeFieldInfoPtr_obj;

		// Token: 0x04002FB4 RID: 12212
		private static readonly IntPtr NativeFieldInfoPtr_objectType;

		// Token: 0x04002FB5 RID: 12213
		private static readonly IntPtr NativeFieldInfoPtr_isSi;

		// Token: 0x04002FB6 RID: 12214
		private static readonly IntPtr NativeFieldInfoPtr_isNamed;

		// Token: 0x04002FB7 RID: 12215
		private static readonly IntPtr NativeFieldInfoPtr_isTyped;

		// Token: 0x04002FB8 RID: 12216
		private static readonly IntPtr NativeFieldInfoPtr_isArray;

		// Token: 0x04002FB9 RID: 12217
		private static readonly IntPtr NativeFieldInfoPtr_si;

		// Token: 0x04002FBA RID: 12218
		private static readonly IntPtr NativeFieldInfoPtr_cache;

		// Token: 0x04002FBB RID: 12219
		private static readonly IntPtr NativeFieldInfoPtr_memberData;

		// Token: 0x04002FBC RID: 12220
		private static readonly IntPtr NativeFieldInfoPtr_serializationSurrogate;

		// Token: 0x04002FBD RID: 12221
		private static readonly IntPtr NativeFieldInfoPtr_context;

		// Token: 0x04002FBE RID: 12222
		private static readonly IntPtr NativeFieldInfoPtr_serObjectInfoInit;

		// Token: 0x04002FBF RID: 12223
		private static readonly IntPtr NativeFieldInfoPtr_objectId;

		// Token: 0x04002FC0 RID: 12224
		private static readonly IntPtr NativeFieldInfoPtr_assemId;

		// Token: 0x04002FC1 RID: 12225
		private static readonly IntPtr NativeFieldInfoPtr_binderTypeName;

		// Token: 0x04002FC2 RID: 12226
		private static readonly IntPtr NativeFieldInfoPtr_binderAssemblyString;

		// Token: 0x04002FC3 RID: 12227
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x04002FC4 RID: 12228
		private static readonly IntPtr NativeMethodInfoPtr_ObjectEnd_Internal_Void_0;

		// Token: 0x04002FC5 RID: 12229
		private static readonly IntPtr NativeMethodInfoPtr_InternalInit_Private_Void_0;

		// Token: 0x04002FC6 RID: 12230
		private static readonly IntPtr NativeMethodInfoPtr_Serialize_Internal_Static_WriteObjectInfo_Object_ISurrogateSelector_StreamingContext_SerObjectInfoInit_IFormatterConverter_ObjectWriter_SerializationBinder_0;

		// Token: 0x04002FC7 RID: 12231
		private static readonly IntPtr NativeMethodInfoPtr_InitSerialize_Internal_Void_Object_ISurrogateSelector_StreamingContext_SerObjectInfoInit_IFormatterConverter_ObjectWriter_SerializationBinder_0;

		// Token: 0x04002FC8 RID: 12232
		private static readonly IntPtr NativeMethodInfoPtr_Serialize_Internal_Static_WriteObjectInfo_Type_ISurrogateSelector_StreamingContext_SerObjectInfoInit_IFormatterConverter_SerializationBinder_0;

		// Token: 0x04002FC9 RID: 12233
		private static readonly IntPtr NativeMethodInfoPtr_InitSerialize_Internal_Void_Type_ISurrogateSelector_StreamingContext_SerObjectInfoInit_IFormatterConverter_SerializationBinder_0;

		// Token: 0x04002FCA RID: 12234
		private static readonly IntPtr NativeMethodInfoPtr_InitSiWrite_Private_Void_0;

		// Token: 0x04002FCB RID: 12235
		private static readonly IntPtr NativeMethodInfoPtr_CheckTypeForwardedFrom_Private_Static_Void_SerObjectInfoCache_Type_String_0;

		// Token: 0x04002FCC RID: 12236
		private static readonly IntPtr NativeMethodInfoPtr_InitNoMembers_Private_Void_0;

		// Token: 0x04002FCD RID: 12237
		private static readonly IntPtr NativeMethodInfoPtr_InitMemberInfo_Private_Void_0;

		// Token: 0x04002FCE RID: 12238
		private static readonly IntPtr NativeMethodInfoPtr_GetTypeFullName_Internal_String_0;

		// Token: 0x04002FCF RID: 12239
		private static readonly IntPtr NativeMethodInfoPtr_GetAssemblyString_Internal_String_0;

		// Token: 0x04002FD0 RID: 12240
		private static readonly IntPtr NativeMethodInfoPtr_InvokeSerializationBinder_Private_Void_SerializationBinder_0;

		// Token: 0x04002FD1 RID: 12241
		private static readonly IntPtr NativeMethodInfoPtr_GetMemberType_Internal_Type_MemberInfo_0;

		// Token: 0x04002FD2 RID: 12242
		private static readonly IntPtr NativeMethodInfoPtr_GetMemberInfo_Internal_Void_byref_Il2CppStringArray_byref_Il2CppReferenceArray_1_Type_byref_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04002FD3 RID: 12243
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectInfo_Private_Static_WriteObjectInfo_SerObjectInfoInit_0;

		// Token: 0x04002FD4 RID: 12244
		private static readonly IntPtr NativeMethodInfoPtr_PutObjectInfo_Private_Static_Void_SerObjectInfoInit_WriteObjectInfo_0;
	}
}
