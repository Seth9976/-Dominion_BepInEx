using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x0200037A RID: 890
	public sealed class ReadObjectInfo : Object
	{
		// Token: 0x060038D4 RID: 14548 RVA: 0x0010FFCC File Offset: 0x0010E1CC
		// Note: this type is marked as 'beforefieldinit'.
		static ReadObjectInfo()
		{
			Il2CppClassPointerStore<ReadObjectInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization.Formatters.Binary", "ReadObjectInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReadObjectInfo>.NativeClassPtr);
			ReadObjectInfo.NativeFieldInfoPtr_objectInfoId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadObjectInfo>.NativeClassPtr, "objectInfoId");
			ReadObjectInfo.NativeFieldInfoPtr_readObjectInfoCounter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadObjectInfo>.NativeClassPtr, "readObjectInfoCounter");
			ReadObjectInfo.NativeFieldInfoPtr_objectType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadObjectInfo>.NativeClassPtr, "objectType");
			ReadObjectInfo.NativeFieldInfoPtr_objectManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadObjectInfo>.NativeClassPtr, "objectManager");
			ReadObjectInfo.NativeFieldInfoPtr_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadObjectInfo>.NativeClassPtr, "count");
			ReadObjectInfo.NativeFieldInfoPtr_isSi = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadObjectInfo>.NativeClassPtr, "isSi");
			ReadObjectInfo.NativeFieldInfoPtr_isNamed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadObjectInfo>.NativeClassPtr, "isNamed");
			ReadObjectInfo.NativeFieldInfoPtr_isTyped = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadObjectInfo>.NativeClassPtr, "isTyped");
			ReadObjectInfo.NativeFieldInfoPtr_bSimpleAssembly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadObjectInfo>.NativeClassPtr, "bSimpleAssembly");
			ReadObjectInfo.NativeFieldInfoPtr_cache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadObjectInfo>.NativeClassPtr, "cache");
			ReadObjectInfo.NativeFieldInfoPtr_wireMemberNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadObjectInfo>.NativeClassPtr, "wireMemberNames");
			ReadObjectInfo.NativeFieldInfoPtr_wireMemberTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadObjectInfo>.NativeClassPtr, "wireMemberTypes");
			ReadObjectInfo.NativeFieldInfoPtr_lastPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadObjectInfo>.NativeClassPtr, "lastPosition");
			ReadObjectInfo.NativeFieldInfoPtr_serializationSurrogate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadObjectInfo>.NativeClassPtr, "serializationSurrogate");
			ReadObjectInfo.NativeFieldInfoPtr_context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadObjectInfo>.NativeClassPtr, "context");
			ReadObjectInfo.NativeFieldInfoPtr_memberTypesList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadObjectInfo>.NativeClassPtr, "memberTypesList");
			ReadObjectInfo.NativeFieldInfoPtr_serObjectInfoInit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadObjectInfo>.NativeClassPtr, "serObjectInfoInit");
			ReadObjectInfo.NativeFieldInfoPtr_formatterConverter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadObjectInfo>.NativeClassPtr, "formatterConverter");
			ReadObjectInfo.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadObjectInfo>.NativeClassPtr, 100671861);
			ReadObjectInfo.NativeMethodInfoPtr_ObjectEnd_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadObjectInfo>.NativeClassPtr, 100671862);
			ReadObjectInfo.NativeMethodInfoPtr_PrepareForReuse_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadObjectInfo>.NativeClassPtr, 100671863);
			ReadObjectInfo.NativeMethodInfoPtr_Create_Internal_Static_ReadObjectInfo_Type_ISurrogateSelector_StreamingContext_ObjectManager_SerObjectInfoInit_IFormatterConverter_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadObjectInfo>.NativeClassPtr, 100671864);
			ReadObjectInfo.NativeMethodInfoPtr_Init_Internal_Void_Type_ISurrogateSelector_StreamingContext_ObjectManager_SerObjectInfoInit_IFormatterConverter_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadObjectInfo>.NativeClassPtr, 100671865);
			ReadObjectInfo.NativeMethodInfoPtr_Create_Internal_Static_ReadObjectInfo_Type_Il2CppStringArray_Il2CppReferenceArray_1_Type_ISurrogateSelector_StreamingContext_ObjectManager_SerObjectInfoInit_IFormatterConverter_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadObjectInfo>.NativeClassPtr, 100671866);
			ReadObjectInfo.NativeMethodInfoPtr_Init_Internal_Void_Type_Il2CppStringArray_Il2CppReferenceArray_1_Type_ISurrogateSelector_StreamingContext_ObjectManager_SerObjectInfoInit_IFormatterConverter_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadObjectInfo>.NativeClassPtr, 100671867);
			ReadObjectInfo.NativeMethodInfoPtr_InitReadConstructor_Private_Void_Type_ISurrogateSelector_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadObjectInfo>.NativeClassPtr, 100671868);
			ReadObjectInfo.NativeMethodInfoPtr_InitSiRead_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadObjectInfo>.NativeClassPtr, 100671869);
			ReadObjectInfo.NativeMethodInfoPtr_InitNoMembers_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadObjectInfo>.NativeClassPtr, 100671870);
			ReadObjectInfo.NativeMethodInfoPtr_InitMemberInfo_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadObjectInfo>.NativeClassPtr, 100671871);
			ReadObjectInfo.NativeMethodInfoPtr_GetMemberInfo_Internal_MemberInfo_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadObjectInfo>.NativeClassPtr, 100671872);
			ReadObjectInfo.NativeMethodInfoPtr_GetType_Internal_Type_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadObjectInfo>.NativeClassPtr, 100671873);
			ReadObjectInfo.NativeMethodInfoPtr_AddValue_Internal_Void_String_Object_byref_SerializationInfo_byref_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadObjectInfo>.NativeClassPtr, 100671874);
			ReadObjectInfo.NativeMethodInfoPtr_InitDataStore_Internal_Void_byref_SerializationInfo_byref_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadObjectInfo>.NativeClassPtr, 100671875);
			ReadObjectInfo.NativeMethodInfoPtr_RecordFixup_Internal_Void_Int64_String_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadObjectInfo>.NativeClassPtr, 100671876);
			ReadObjectInfo.NativeMethodInfoPtr_PopulateObjectMembers_Internal_Void_Object_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadObjectInfo>.NativeClassPtr, 100671877);
			ReadObjectInfo.NativeMethodInfoPtr_Position_Private_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadObjectInfo>.NativeClassPtr, 100671878);
			ReadObjectInfo.NativeMethodInfoPtr_GetMemberTypes_Internal_Il2CppReferenceArray_1_Type_Il2CppStringArray_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadObjectInfo>.NativeClassPtr, 100671879);
			ReadObjectInfo.NativeMethodInfoPtr_GetMemberType_Internal_Type_MemberInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadObjectInfo>.NativeClassPtr, 100671880);
			ReadObjectInfo.NativeMethodInfoPtr_GetObjectInfo_Private_Static_ReadObjectInfo_SerObjectInfoInit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadObjectInfo>.NativeClassPtr, 100671881);
		}

		// Token: 0x060038D5 RID: 14549 RVA: 0x00110308 File Offset: 0x0010E508
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReadObjectInfo()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReadObjectInfo>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadObjectInfo.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038D6 RID: 14550 RVA: 0x00110344 File Offset: 0x0010E544
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ObjectEnd()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadObjectInfo.NativeMethodInfoPtr_ObjectEnd_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038D7 RID: 14551 RVA: 0x00110378 File Offset: 0x0010E578
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 346307, RefRangeEnd = 346308, XrefRangeStart = 346307, XrefRangeEnd = 346307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PrepareForReuse()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadObjectInfo.NativeMethodInfoPtr_PrepareForReuse_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038D8 RID: 14552 RVA: 0x001103AC File Offset: 0x0010E5AC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 346315, RefRangeEnd = 346318, XrefRangeStart = 346308, XrefRangeEnd = 346315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ReadObjectInfo Create(Type objectType, ISurrogateSelector surrogateSelector, StreamingContext context, ObjectManager objectManager, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, bool bSimpleAssembly)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(objectType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(surrogateSelector);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(objectManager);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(serObjectInfoInit);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(converter);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bSimpleAssembly;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadObjectInfo.NativeMethodInfoPtr_Create_Internal_Static_ReadObjectInfo_Type_ISurrogateSelector_StreamingContext_ObjectManager_SerObjectInfoInit_IFormatterConverter_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadObjectInfo>(intPtr3) : null;
		}

		// Token: 0x060038D9 RID: 14553 RVA: 0x00110460 File Offset: 0x0010E660
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 346318, XrefRangeEnd = 346319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Init(Type objectType, ISurrogateSelector surrogateSelector, StreamingContext context, ObjectManager objectManager, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, bool bSimpleAssembly)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(objectType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(surrogateSelector);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(objectManager);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(serObjectInfoInit);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(converter);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bSimpleAssembly;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadObjectInfo.NativeMethodInfoPtr_Init_Internal_Void_Type_ISurrogateSelector_StreamingContext_ObjectManager_SerObjectInfoInit_IFormatterConverter_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038DA RID: 14554 RVA: 0x00110514 File Offset: 0x0010E714
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 346326, RefRangeEnd = 346328, XrefRangeStart = 346319, XrefRangeEnd = 346326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ReadObjectInfo Create(Type objectType, Il2CppStringArray memberNames, Il2CppReferenceArray<Type> memberTypes, ISurrogateSelector surrogateSelector, StreamingContext context, ObjectManager objectManager, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, bool bSimpleAssembly)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(objectType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(memberNames);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(memberTypes);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(surrogateSelector);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(objectManager);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(serObjectInfoInit);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(converter);
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bSimpleAssembly;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadObjectInfo.NativeMethodInfoPtr_Create_Internal_Static_ReadObjectInfo_Type_Il2CppStringArray_Il2CppReferenceArray_1_Type_ISurrogateSelector_StreamingContext_ObjectManager_SerObjectInfoInit_IFormatterConverter_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadObjectInfo>(intPtr3) : null;
		}

		// Token: 0x060038DB RID: 14555 RVA: 0x001105F0 File Offset: 0x0010E7F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 346328, XrefRangeEnd = 346329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Init(Type objectType, Il2CppStringArray memberNames, Il2CppReferenceArray<Type> memberTypes, ISurrogateSelector surrogateSelector, StreamingContext context, ObjectManager objectManager, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, bool bSimpleAssembly)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(objectType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(memberNames);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(memberTypes);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(surrogateSelector);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(objectManager);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(serObjectInfoInit);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(converter);
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bSimpleAssembly;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadObjectInfo.NativeMethodInfoPtr_Init_Internal_Void_Type_Il2CppStringArray_Il2CppReferenceArray_1_Type_ISurrogateSelector_StreamingContext_ObjectManager_SerObjectInfoInit_IFormatterConverter_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038DC RID: 14556 RVA: 0x001106CC File Offset: 0x0010E8CC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 346340, RefRangeEnd = 346344, XrefRangeStart = 346329, XrefRangeEnd = 346340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitReadConstructor(Type objectType, ISurrogateSelector surrogateSelector, StreamingContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(objectType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(surrogateSelector);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadObjectInfo.NativeMethodInfoPtr_InitReadConstructor_Private_Void_Type_ISurrogateSelector_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038DD RID: 14557 RVA: 0x00110738 File Offset: 0x0010E938
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 346344, XrefRangeEnd = 346350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitSiRead()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadObjectInfo.NativeMethodInfoPtr_InitSiRead_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038DE RID: 14558 RVA: 0x0011076C File Offset: 0x0010E96C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 346350, XrefRangeEnd = 346354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitNoMembers()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadObjectInfo.NativeMethodInfoPtr_InitNoMembers_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038DF RID: 14559 RVA: 0x001107A0 File Offset: 0x0010E9A0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 346371, RefRangeEnd = 346372, XrefRangeStart = 346354, XrefRangeEnd = 346371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitMemberInfo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadObjectInfo.NativeMethodInfoPtr_InitMemberInfo_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038E0 RID: 14560 RVA: 0x001107D4 File Offset: 0x0010E9D4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 346373, RefRangeEnd = 346377, XrefRangeStart = 346372, XrefRangeEnd = 346373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MemberInfo GetMemberInfo(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadObjectInfo.NativeMethodInfoPtr_GetMemberInfo_Internal_MemberInfo_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MemberInfo>(intPtr3) : null;
			}
		}

		// Token: 0x060038E1 RID: 14561 RVA: 0x00110824 File Offset: 0x0010EA24
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 346382, RefRangeEnd = 346383, XrefRangeStart = 346377, XrefRangeEnd = 346382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Type GetType(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadObjectInfo.NativeMethodInfoPtr_GetType_Internal_Type_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x060038E2 RID: 14562 RVA: 0x00110874 File Offset: 0x0010EA74
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 346385, RefRangeEnd = 346386, XrefRangeStart = 346383, XrefRangeEnd = 346385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddValue(string name, Object value, ref SerializationInfo si, ref Il2CppReferenceArray<Object> memberData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(si);
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr(memberData);
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(ReadObjectInfo.NativeMethodInfoPtr_AddValue_Internal_Void_String_Object_byref_SerializationInfo_byref_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			si = ((intPtr5 == 0) ? null : new SerializationInfo(intPtr5));
			IntPtr intPtr6 = intPtr2;
			memberData = ((intPtr6 == 0) ? null : new Il2CppReferenceArray<Object>(intPtr6));
		}

		// Token: 0x060038E3 RID: 14563 RVA: 0x0011091C File Offset: 0x0010EB1C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 346390, RefRangeEnd = 346391, XrefRangeStart = 346386, XrefRangeEnd = 346390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitDataStore(ref SerializationInfo si, ref Il2CppReferenceArray<Object> memberData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(si);
				ptr2 = &intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr(memberData);
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(ReadObjectInfo.NativeMethodInfoPtr_InitDataStore_Internal_Void_byref_SerializationInfo_byref_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			si = ((intPtr5 == 0) ? null : new SerializationInfo(intPtr5));
			IntPtr intPtr6 = intPtr2;
			memberData = ((intPtr6 == 0) ? null : new Il2CppReferenceArray<Object>(intPtr6));
		}

		// Token: 0x060038E4 RID: 14564 RVA: 0x0011099C File Offset: 0x0010EB9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 346391, XrefRangeEnd = 346392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RecordFixup(long objectId, string name, long idRef)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref objectId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref idRef;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadObjectInfo.NativeMethodInfoPtr_RecordFixup_Internal_Void_Int64_String_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038E5 RID: 14565 RVA: 0x001109FC File Offset: 0x0010EBFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 346392, XrefRangeEnd = 346396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PopulateObjectMembers(Object obj, Il2CppReferenceArray<Object> memberData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(memberData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadObjectInfo.NativeMethodInfoPtr_PopulateObjectMembers_Internal_Void_Object_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038E6 RID: 14566 RVA: 0x00110A50 File Offset: 0x0010EC50
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 346398, RefRangeEnd = 346402, XrefRangeStart = 346396, XrefRangeEnd = 346398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int Position(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadObjectInfo.NativeMethodInfoPtr_Position_Private_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060038E7 RID: 14567 RVA: 0x00110AA0 File Offset: 0x0010ECA0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 346423, RefRangeEnd = 346425, XrefRangeStart = 346402, XrefRangeEnd = 346423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<Type> GetMemberTypes(Il2CppStringArray inMemberNames, Type objectType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inMemberNames);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(objectType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadObjectInfo.NativeMethodInfoPtr_GetMemberTypes_Internal_Il2CppReferenceArray_1_Type_Il2CppStringArray_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Type>>(intPtr3) : null;
		}

		// Token: 0x060038E8 RID: 14568 RVA: 0x00110B04 File Offset: 0x0010ED04
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 346429, RefRangeEnd = 346431, XrefRangeStart = 346425, XrefRangeEnd = 346429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Type GetMemberType(MemberInfo objMember)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(objMember);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadObjectInfo.NativeMethodInfoPtr_GetMemberType_Internal_Type_MemberInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x060038E9 RID: 14569 RVA: 0x00110B54 File Offset: 0x0010ED54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 346431, XrefRangeEnd = 346437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ReadObjectInfo GetObjectInfo(SerObjectInfoInit serObjectInfoInit)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serObjectInfoInit);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadObjectInfo.NativeMethodInfoPtr_GetObjectInfo_Private_Static_ReadObjectInfo_SerObjectInfoInit_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadObjectInfo>(intPtr3) : null;
			}
		}

		// Token: 0x060038EA RID: 14570 RVA: 0x00014DAD File Offset: 0x00012FAD
		public ReadObjectInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000DF0 RID: 3568
		// (get) Token: 0x060038EB RID: 14571 RVA: 0x00110B98 File Offset: 0x0010ED98
		// (set) Token: 0x060038EC RID: 14572 RVA: 0x00014DB6 File Offset: 0x00012FB6
		public unsafe int objectInfoId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadObjectInfo.NativeFieldInfoPtr_objectInfoId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadObjectInfo.NativeFieldInfoPtr_objectInfoId)) = value;
			}
		}

		// Token: 0x17000DF1 RID: 3569
		// (get) Token: 0x060038ED RID: 14573 RVA: 0x00110BC0 File Offset: 0x0010EDC0
		// (set) Token: 0x060038EE RID: 14574 RVA: 0x00014DD1 File Offset: 0x00012FD1
		public unsafe static int readObjectInfoCounter
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ReadObjectInfo.NativeFieldInfoPtr_readObjectInfoCounter, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ReadObjectInfo.NativeFieldInfoPtr_readObjectInfoCounter, (void*)(&value));
			}
		}

		// Token: 0x17000DF2 RID: 3570
		// (get) Token: 0x060038EF RID: 14575 RVA: 0x00110BDC File Offset: 0x0010EDDC
		// (set) Token: 0x060038F0 RID: 14576 RVA: 0x00014DDF File Offset: 0x00012FDF
		public unsafe Type objectType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadObjectInfo.NativeFieldInfoPtr_objectType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadObjectInfo.NativeFieldInfoPtr_objectType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DF3 RID: 3571
		// (get) Token: 0x060038F1 RID: 14577 RVA: 0x00110C0C File Offset: 0x0010EE0C
		// (set) Token: 0x060038F2 RID: 14578 RVA: 0x00014DFE File Offset: 0x00012FFE
		public unsafe ObjectManager objectManager
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadObjectInfo.NativeFieldInfoPtr_objectManager);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadObjectInfo.NativeFieldInfoPtr_objectManager), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DF4 RID: 3572
		// (get) Token: 0x060038F3 RID: 14579 RVA: 0x00110C3C File Offset: 0x0010EE3C
		// (set) Token: 0x060038F4 RID: 14580 RVA: 0x00014E1D File Offset: 0x0001301D
		public unsafe int count
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadObjectInfo.NativeFieldInfoPtr_count);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadObjectInfo.NativeFieldInfoPtr_count)) = value;
			}
		}

		// Token: 0x17000DF5 RID: 3573
		// (get) Token: 0x060038F5 RID: 14581 RVA: 0x00110C64 File Offset: 0x0010EE64
		// (set) Token: 0x060038F6 RID: 14582 RVA: 0x00014E38 File Offset: 0x00013038
		public unsafe bool isSi
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadObjectInfo.NativeFieldInfoPtr_isSi);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadObjectInfo.NativeFieldInfoPtr_isSi)) = value;
			}
		}

		// Token: 0x17000DF6 RID: 3574
		// (get) Token: 0x060038F7 RID: 14583 RVA: 0x00110C8C File Offset: 0x0010EE8C
		// (set) Token: 0x060038F8 RID: 14584 RVA: 0x00014E53 File Offset: 0x00013053
		public unsafe bool isNamed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadObjectInfo.NativeFieldInfoPtr_isNamed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadObjectInfo.NativeFieldInfoPtr_isNamed)) = value;
			}
		}

		// Token: 0x17000DF7 RID: 3575
		// (get) Token: 0x060038F9 RID: 14585 RVA: 0x00110CB4 File Offset: 0x0010EEB4
		// (set) Token: 0x060038FA RID: 14586 RVA: 0x00014E6E File Offset: 0x0001306E
		public unsafe bool isTyped
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadObjectInfo.NativeFieldInfoPtr_isTyped);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadObjectInfo.NativeFieldInfoPtr_isTyped)) = value;
			}
		}

		// Token: 0x17000DF8 RID: 3576
		// (get) Token: 0x060038FB RID: 14587 RVA: 0x00110CDC File Offset: 0x0010EEDC
		// (set) Token: 0x060038FC RID: 14588 RVA: 0x00014E89 File Offset: 0x00013089
		public unsafe bool bSimpleAssembly
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadObjectInfo.NativeFieldInfoPtr_bSimpleAssembly);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadObjectInfo.NativeFieldInfoPtr_bSimpleAssembly)) = value;
			}
		}

		// Token: 0x17000DF9 RID: 3577
		// (get) Token: 0x060038FD RID: 14589 RVA: 0x00110D04 File Offset: 0x0010EF04
		// (set) Token: 0x060038FE RID: 14590 RVA: 0x00014EA4 File Offset: 0x000130A4
		public unsafe SerObjectInfoCache cache
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadObjectInfo.NativeFieldInfoPtr_cache);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerObjectInfoCache>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadObjectInfo.NativeFieldInfoPtr_cache), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DFA RID: 3578
		// (get) Token: 0x060038FF RID: 14591 RVA: 0x00110D34 File Offset: 0x0010EF34
		// (set) Token: 0x06003900 RID: 14592 RVA: 0x00014EC3 File Offset: 0x000130C3
		public unsafe Il2CppStringArray wireMemberNames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadObjectInfo.NativeFieldInfoPtr_wireMemberNames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadObjectInfo.NativeFieldInfoPtr_wireMemberNames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DFB RID: 3579
		// (get) Token: 0x06003901 RID: 14593 RVA: 0x00110D64 File Offset: 0x0010EF64
		// (set) Token: 0x06003902 RID: 14594 RVA: 0x00014EE2 File Offset: 0x000130E2
		public unsafe Il2CppReferenceArray<Type> wireMemberTypes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadObjectInfo.NativeFieldInfoPtr_wireMemberTypes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Type>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadObjectInfo.NativeFieldInfoPtr_wireMemberTypes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DFC RID: 3580
		// (get) Token: 0x06003903 RID: 14595 RVA: 0x00110D94 File Offset: 0x0010EF94
		// (set) Token: 0x06003904 RID: 14596 RVA: 0x00014F01 File Offset: 0x00013101
		public unsafe int lastPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadObjectInfo.NativeFieldInfoPtr_lastPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadObjectInfo.NativeFieldInfoPtr_lastPosition)) = value;
			}
		}

		// Token: 0x17000DFD RID: 3581
		// (get) Token: 0x06003905 RID: 14597 RVA: 0x00110DBC File Offset: 0x0010EFBC
		// (set) Token: 0x06003906 RID: 14598 RVA: 0x00014F1C File Offset: 0x0001311C
		public unsafe ISerializationSurrogate serializationSurrogate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadObjectInfo.NativeFieldInfoPtr_serializationSurrogate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ISerializationSurrogate>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadObjectInfo.NativeFieldInfoPtr_serializationSurrogate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DFE RID: 3582
		// (get) Token: 0x06003907 RID: 14599 RVA: 0x00110DEC File Offset: 0x0010EFEC
		// (set) Token: 0x06003908 RID: 14600 RVA: 0x00014F3B File Offset: 0x0001313B
		public StreamingContext context
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadObjectInfo.NativeFieldInfoPtr_context);
				return new StreamingContext(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StreamingContext>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadObjectInfo.NativeFieldInfoPtr_context), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<StreamingContext>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000DFF RID: 3583
		// (get) Token: 0x06003909 RID: 14601 RVA: 0x00110E1C File Offset: 0x0010F01C
		// (set) Token: 0x0600390A RID: 14602 RVA: 0x00014F69 File Offset: 0x00013169
		public unsafe List<Type> memberTypesList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadObjectInfo.NativeFieldInfoPtr_memberTypesList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Type>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadObjectInfo.NativeFieldInfoPtr_memberTypesList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E00 RID: 3584
		// (get) Token: 0x0600390B RID: 14603 RVA: 0x00110E4C File Offset: 0x0010F04C
		// (set) Token: 0x0600390C RID: 14604 RVA: 0x00014F88 File Offset: 0x00013188
		public unsafe SerObjectInfoInit serObjectInfoInit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadObjectInfo.NativeFieldInfoPtr_serObjectInfoInit);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerObjectInfoInit>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadObjectInfo.NativeFieldInfoPtr_serObjectInfoInit), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E01 RID: 3585
		// (get) Token: 0x0600390D RID: 14605 RVA: 0x00110E7C File Offset: 0x0010F07C
		// (set) Token: 0x0600390E RID: 14606 RVA: 0x00014FA7 File Offset: 0x000131A7
		public unsafe IFormatterConverter formatterConverter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadObjectInfo.NativeFieldInfoPtr_formatterConverter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IFormatterConverter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadObjectInfo.NativeFieldInfoPtr_formatterConverter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002FD5 RID: 12245
		private static readonly IntPtr NativeFieldInfoPtr_objectInfoId;

		// Token: 0x04002FD6 RID: 12246
		private static readonly IntPtr NativeFieldInfoPtr_readObjectInfoCounter;

		// Token: 0x04002FD7 RID: 12247
		private static readonly IntPtr NativeFieldInfoPtr_objectType;

		// Token: 0x04002FD8 RID: 12248
		private static readonly IntPtr NativeFieldInfoPtr_objectManager;

		// Token: 0x04002FD9 RID: 12249
		private static readonly IntPtr NativeFieldInfoPtr_count;

		// Token: 0x04002FDA RID: 12250
		private static readonly IntPtr NativeFieldInfoPtr_isSi;

		// Token: 0x04002FDB RID: 12251
		private static readonly IntPtr NativeFieldInfoPtr_isNamed;

		// Token: 0x04002FDC RID: 12252
		private static readonly IntPtr NativeFieldInfoPtr_isTyped;

		// Token: 0x04002FDD RID: 12253
		private static readonly IntPtr NativeFieldInfoPtr_bSimpleAssembly;

		// Token: 0x04002FDE RID: 12254
		private static readonly IntPtr NativeFieldInfoPtr_cache;

		// Token: 0x04002FDF RID: 12255
		private static readonly IntPtr NativeFieldInfoPtr_wireMemberNames;

		// Token: 0x04002FE0 RID: 12256
		private static readonly IntPtr NativeFieldInfoPtr_wireMemberTypes;

		// Token: 0x04002FE1 RID: 12257
		private static readonly IntPtr NativeFieldInfoPtr_lastPosition;

		// Token: 0x04002FE2 RID: 12258
		private static readonly IntPtr NativeFieldInfoPtr_serializationSurrogate;

		// Token: 0x04002FE3 RID: 12259
		private static readonly IntPtr NativeFieldInfoPtr_context;

		// Token: 0x04002FE4 RID: 12260
		private static readonly IntPtr NativeFieldInfoPtr_memberTypesList;

		// Token: 0x04002FE5 RID: 12261
		private static readonly IntPtr NativeFieldInfoPtr_serObjectInfoInit;

		// Token: 0x04002FE6 RID: 12262
		private static readonly IntPtr NativeFieldInfoPtr_formatterConverter;

		// Token: 0x04002FE7 RID: 12263
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x04002FE8 RID: 12264
		private static readonly IntPtr NativeMethodInfoPtr_ObjectEnd_Internal_Void_0;

		// Token: 0x04002FE9 RID: 12265
		private static readonly IntPtr NativeMethodInfoPtr_PrepareForReuse_Internal_Void_0;

		// Token: 0x04002FEA RID: 12266
		private static readonly IntPtr NativeMethodInfoPtr_Create_Internal_Static_ReadObjectInfo_Type_ISurrogateSelector_StreamingContext_ObjectManager_SerObjectInfoInit_IFormatterConverter_Boolean_0;

		// Token: 0x04002FEB RID: 12267
		private static readonly IntPtr NativeMethodInfoPtr_Init_Internal_Void_Type_ISurrogateSelector_StreamingContext_ObjectManager_SerObjectInfoInit_IFormatterConverter_Boolean_0;

		// Token: 0x04002FEC RID: 12268
		private static readonly IntPtr NativeMethodInfoPtr_Create_Internal_Static_ReadObjectInfo_Type_Il2CppStringArray_Il2CppReferenceArray_1_Type_ISurrogateSelector_StreamingContext_ObjectManager_SerObjectInfoInit_IFormatterConverter_Boolean_0;

		// Token: 0x04002FED RID: 12269
		private static readonly IntPtr NativeMethodInfoPtr_Init_Internal_Void_Type_Il2CppStringArray_Il2CppReferenceArray_1_Type_ISurrogateSelector_StreamingContext_ObjectManager_SerObjectInfoInit_IFormatterConverter_Boolean_0;

		// Token: 0x04002FEE RID: 12270
		private static readonly IntPtr NativeMethodInfoPtr_InitReadConstructor_Private_Void_Type_ISurrogateSelector_StreamingContext_0;

		// Token: 0x04002FEF RID: 12271
		private static readonly IntPtr NativeMethodInfoPtr_InitSiRead_Private_Void_0;

		// Token: 0x04002FF0 RID: 12272
		private static readonly IntPtr NativeMethodInfoPtr_InitNoMembers_Private_Void_0;

		// Token: 0x04002FF1 RID: 12273
		private static readonly IntPtr NativeMethodInfoPtr_InitMemberInfo_Private_Void_0;

		// Token: 0x04002FF2 RID: 12274
		private static readonly IntPtr NativeMethodInfoPtr_GetMemberInfo_Internal_MemberInfo_String_0;

		// Token: 0x04002FF3 RID: 12275
		private static readonly IntPtr NativeMethodInfoPtr_GetType_Internal_Type_String_0;

		// Token: 0x04002FF4 RID: 12276
		private static readonly IntPtr NativeMethodInfoPtr_AddValue_Internal_Void_String_Object_byref_SerializationInfo_byref_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04002FF5 RID: 12277
		private static readonly IntPtr NativeMethodInfoPtr_InitDataStore_Internal_Void_byref_SerializationInfo_byref_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04002FF6 RID: 12278
		private static readonly IntPtr NativeMethodInfoPtr_RecordFixup_Internal_Void_Int64_String_Int64_0;

		// Token: 0x04002FF7 RID: 12279
		private static readonly IntPtr NativeMethodInfoPtr_PopulateObjectMembers_Internal_Void_Object_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04002FF8 RID: 12280
		private static readonly IntPtr NativeMethodInfoPtr_Position_Private_Int32_String_0;

		// Token: 0x04002FF9 RID: 12281
		private static readonly IntPtr NativeMethodInfoPtr_GetMemberTypes_Internal_Il2CppReferenceArray_1_Type_Il2CppStringArray_Type_0;

		// Token: 0x04002FFA RID: 12282
		private static readonly IntPtr NativeMethodInfoPtr_GetMemberType_Internal_Type_MemberInfo_0;

		// Token: 0x04002FFB RID: 12283
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectInfo_Private_Static_ReadObjectInfo_SerObjectInfoInit_0;
	}
}
