using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Text
{
	// Token: 0x02000170 RID: 368
	[DefaultMember("Item")]
	[Serializable]
	public sealed class StringBuilder : Object
	{
		// Token: 0x06001924 RID: 6436 RVA: 0x00093174 File Offset: 0x00091374
		// Note: this type is marked as 'beforefieldinit'.
		static StringBuilder()
		{
			Il2CppClassPointerStore<StringBuilder>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Text", "StringBuilder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StringBuilder>.NativeClassPtr);
			StringBuilder.NativeFieldInfoPtr_m_ChunkChars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringBuilder>.NativeClassPtr, "m_ChunkChars");
			StringBuilder.NativeFieldInfoPtr_m_ChunkPrevious = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringBuilder>.NativeClassPtr, "m_ChunkPrevious");
			StringBuilder.NativeFieldInfoPtr_m_ChunkLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringBuilder>.NativeClassPtr, "m_ChunkLength");
			StringBuilder.NativeFieldInfoPtr_m_ChunkOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringBuilder>.NativeClassPtr, "m_ChunkOffset");
			StringBuilder.NativeFieldInfoPtr_m_MaxCapacity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringBuilder>.NativeClassPtr, "m_MaxCapacity");
			StringBuilder.NativeFieldInfoPtr_DefaultCapacity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringBuilder>.NativeClassPtr, "DefaultCapacity");
			StringBuilder.NativeFieldInfoPtr_CapacityField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringBuilder>.NativeClassPtr, "CapacityField");
			StringBuilder.NativeFieldInfoPtr_MaxCapacityField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringBuilder>.NativeClassPtr, "MaxCapacityField");
			StringBuilder.NativeFieldInfoPtr_StringValueField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringBuilder>.NativeClassPtr, "StringValueField");
			StringBuilder.NativeFieldInfoPtr_ThreadIDField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringBuilder>.NativeClassPtr, "ThreadIDField");
			StringBuilder.NativeFieldInfoPtr_MaxChunkSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringBuilder>.NativeClassPtr, "MaxChunkSize");
			StringBuilder.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringBuilder>.NativeClassPtr, 100667499);
			StringBuilder.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringBuilder>.NativeClassPtr, 100667500);
			StringBuilder.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringBuilder>.NativeClassPtr, 100667501);
			StringBuilder.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringBuilder>.NativeClassPtr, 100667502);
			StringBuilder.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringBuilder>.NativeClassPtr, 100667503);
			StringBuilder.NativeMethodInfoPtr__ctor_Private_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringBuilder>.NativeClassPtr, 100667504);
			StringBuilder.NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringBuilder>.NativeClassPtr, 100667505);
			StringBuilder.NativeMethodInfoPtr_get_Capacity_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringBuilder>.NativeClassPtr, 100667506);
			StringBuilder.NativeMethodInfoPtr_get_MaxCapacity_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringBuilder>.NativeClassPtr, 100667507);
			StringBuilder.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringBuilder>.NativeClassPtr, 100667508);
			StringBuilder.NativeMethodInfoPtr_ToString_Public_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringBuilder>.NativeClassPtr, 100667509);
			StringBuilder.NativeMethodInfoPtr_Clear_Public_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringBuilder>.NativeClassPtr, 100667510);
			StringBuilder.NativeMethodInfoPtr_get_Length_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringBuilder>.NativeClassPtr, 100667511);
			StringBuilder.NativeMethodInfoPtr_set_Length_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringBuilder>.NativeClassPtr, 100667512);
			StringBuilder.NativeMethodInfoPtr_get_Chars_Public_get_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringBuilder>.NativeClassPtr, 100667513);
			StringBuilder.NativeMethodInfoPtr_set_Chars_Public_set_Void_Int32_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringBuilder>.NativeClassPtr, 100667514);
			StringBuilder.NativeMethodInfoPtr_Append_Public_StringBuilder_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringBuilder>.NativeClassPtr, 100667515);
			StringBuilder.NativeMethodInfoPtr_Append_Public_StringBuilder_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringBuilder>.NativeClassPtr, 100667516);
			StringBuilder.NativeMethodInfoPtr_Append_Public_StringBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringBuilder>.NativeClassPtr, 100667517);
			StringBuilder.NativeMethodInfoPtr_AppendHelper_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringBuilder>.NativeClassPtr, 100667518);
			StringBuilder.NativeMethodInfoPtr_Append_Public_StringBuilder_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringBuilder>.NativeClassPtr, 100667519);
			StringBuilder.NativeMethodInfoPtr_AppendLine_Public_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringBuilder>.NativeClassPtr, 100667520);
			StringBuilder.NativeMethodInfoPtr_AppendLine_Public_StringBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringBuilder>.NativeClassPtr, 100667521);
			StringBuilder.NativeMethodInfoPtr_Insert_Public_StringBuilder_Int32_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringBuilder>.NativeClassPtr, 100667522);
			StringBuilder.NativeMethodInfoPtr_Remove_Public_StringBuilder_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringBuilder>.NativeClassPtr, 100667523);
			StringBuilder.NativeMethodInfoPtr_Append_Public_StringBuilder_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringBuilder>.NativeClassPtr, 100667524);
			StringBuilder.NativeMethodInfoPtr_Append_Public_StringBuilder_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringBuilder>.NativeClassPtr, 100667525);
			StringBuilder.NativeMethodInfoPtr_Append_Public_StringBuilder_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringBuilder>.NativeClassPtr, 100667526);
			StringBuilder.NativeMethodInfoPtr_Append_Public_StringBuilder_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringBuilder>.NativeClassPtr, 100667527);
			StringBuilder.NativeMethodInfoPtr_Append_Public_StringBuilder_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringBuilder>.NativeClassPtr, 100667528);
			StringBuilder.NativeMethodInfoPtr_Append_Public_StringBuilder_Il2CppStructArray_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringBuilder>.NativeClassPtr, 100667529);
			StringBuilder.NativeMethodInfoPtr_Insert_Public_StringBuilder_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringBuilder>.NativeClassPtr, 100667530);
			StringBuilder.NativeMethodInfoPtr_Insert_Public_StringBuilder_Int32_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringBuilder>.NativeClassPtr, 100667531);
			StringBuilder.NativeMethodInfoPtr_AppendFormat_Public_StringBuilder_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringBuilder>.NativeClassPtr, 100667532);
			StringBuilder.NativeMethodInfoPtr_AppendFormat_Public_StringBuilder_String_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringBuilder>.NativeClassPtr, 100667533);
			StringBuilder.NativeMethodInfoPtr_AppendFormat_Public_StringBuilder_String_Object_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringBuilder>.NativeClassPtr, 100667534);
			StringBuilder.NativeMethodInfoPtr_AppendFormat_Public_StringBuilder_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringBuilder>.NativeClassPtr, 100667535);
			StringBuilder.NativeMethodInfoPtr_AppendFormat_Public_StringBuilder_IFormatProvider_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringBuilder>.NativeClassPtr, 100667536);
			StringBuilder.NativeMethodInfoPtr_AppendFormat_Public_StringBuilder_IFormatProvider_String_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringBuilder>.NativeClassPtr, 100667537);
			StringBuilder.NativeMethodInfoPtr_FormatError_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringBuilder>.NativeClassPtr, 100667538);
			StringBuilder.NativeMethodInfoPtr_AppendFormatHelper_Internal_StringBuilder_IFormatProvider_String_ParamsArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringBuilder>.NativeClassPtr, 100667539);
			StringBuilder.NativeMethodInfoPtr_Replace_Public_StringBuilder_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringBuilder>.NativeClassPtr, 100667540);
			StringBuilder.NativeMethodInfoPtr_Replace_Public_StringBuilder_String_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringBuilder>.NativeClassPtr, 100667541);
			StringBuilder.NativeMethodInfoPtr_Append_Public_StringBuilder_ptr_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringBuilder>.NativeClassPtr, 100667542);
			StringBuilder.NativeMethodInfoPtr_Insert_Private_Void_Int32_ptr_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringBuilder>.NativeClassPtr, 100667543);
			StringBuilder.NativeMethodInfoPtr_ReplaceAllInChunk_Private_Void_Il2CppStructArray_1_Int32_Int32_StringBuilder_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringBuilder>.NativeClassPtr, 100667544);
			StringBuilder.NativeMethodInfoPtr_StartsWith_Private_Boolean_StringBuilder_Int32_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringBuilder>.NativeClassPtr, 100667545);
			StringBuilder.NativeMethodInfoPtr_ReplaceInPlaceAtChunk_Private_Void_byref_StringBuilder_byref_Int32_ptr_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringBuilder>.NativeClassPtr, 100667546);
			StringBuilder.NativeMethodInfoPtr_ThreadSafeCopy_Private_Static_Void_ptr_Char_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringBuilder>.NativeClassPtr, 100667547);
			StringBuilder.NativeMethodInfoPtr_ThreadSafeCopy_Private_Static_Void_Il2CppStructArray_1_Char_Int32_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringBuilder>.NativeClassPtr, 100667548);
			StringBuilder.NativeMethodInfoPtr_FindChunkForIndex_Private_StringBuilder_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringBuilder>.NativeClassPtr, 100667549);
			StringBuilder.NativeMethodInfoPtr_Next_Private_StringBuilder_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringBuilder>.NativeClassPtr, 100667550);
			StringBuilder.NativeMethodInfoPtr_ExpandByABlock_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringBuilder>.NativeClassPtr, 100667551);
			StringBuilder.NativeMethodInfoPtr__ctor_Private_Void_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringBuilder>.NativeClassPtr, 100667552);
			StringBuilder.NativeMethodInfoPtr_MakeRoom_Private_Void_Int32_Int32_byref_StringBuilder_byref_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringBuilder>.NativeClassPtr, 100667553);
			StringBuilder.NativeMethodInfoPtr__ctor_Private_Void_Int32_Int32_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringBuilder>.NativeClassPtr, 100667554);
			StringBuilder.NativeMethodInfoPtr_Remove_Private_Void_Int32_Int32_byref_StringBuilder_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringBuilder>.NativeClassPtr, 100667555);
		}

		// Token: 0x06001925 RID: 6437 RVA: 0x000936F4 File Offset: 0x000918F4
		[CallerCount(152)]
		[CachedScanResults(RefRangeStart = 311660, RefRangeEnd = 311812, XrefRangeStart = 311656, XrefRangeEnd = 311660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StringBuilder()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StringBuilder>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringBuilder.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001926 RID: 6438 RVA: 0x00093730 File Offset: 0x00091930
		[CallerCount(46)]
		[CachedScanResults(RefRangeStart = 311816, RefRangeEnd = 311862, XrefRangeStart = 311812, XrefRangeEnd = 311816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StringBuilder(int capacity)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StringBuilder>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref capacity;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringBuilder.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001927 RID: 6439 RVA: 0x00093778 File Offset: 0x00091978
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 311864, RefRangeEnd = 311879, XrefRangeStart = 311862, XrefRangeEnd = 311864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StringBuilder(string value)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StringBuilder>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringBuilder.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001928 RID: 6440 RVA: 0x000937C4 File Offset: 0x000919C4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 311881, RefRangeEnd = 311883, XrefRangeStart = 311879, XrefRangeEnd = 311881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StringBuilder(string value, int capacity)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StringBuilder>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref capacity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringBuilder.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001929 RID: 6441 RVA: 0x00093820 File Offset: 0x00091A20
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 311938, RefRangeEnd = 311946, XrefRangeStart = 311883, XrefRangeEnd = 311938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StringBuilder(string value, int startIndex, int length, int capacity)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StringBuilder>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref capacity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringBuilder.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600192A RID: 6442 RVA: 0x00093898 File Offset: 0x00091A98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311946, XrefRangeEnd = 311975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StringBuilder(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StringBuilder>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringBuilder.NativeMethodInfoPtr__ctor_Private_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600192B RID: 6443 RVA: 0x000938FC File Offset: 0x00091AFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311975, XrefRangeEnd = 311994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Runtime_Serialization_ISerializable_GetObjectData(SerializationInfo info, StreamingContext context)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringBuilder.NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000502 RID: 1282
		// (get) Token: 0x0600192C RID: 6444 RVA: 0x00093958 File Offset: 0x00091B58
		public unsafe int Capacity
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringBuilder.NativeMethodInfoPtr_get_Capacity_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000503 RID: 1283
		// (get) Token: 0x0600192D RID: 6445 RVA: 0x00093994 File Offset: 0x00091B94
		public unsafe int MaxCapacity
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 12781, RefRangeEnd = 12782, XrefRangeStart = 12781, XrefRangeEnd = 12782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringBuilder.NativeMethodInfoPtr_get_MaxCapacity_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600192E RID: 6446 RVA: 0x000939D0 File Offset: 0x00091BD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311994, XrefRangeEnd = 311999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringBuilder.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600192F RID: 6447 RVA: 0x00093A08 File Offset: 0x00091C08
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 312002, RefRangeEnd = 312006, XrefRangeStart = 311999, XrefRangeEnd = 312002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ToString(int startIndex, int length)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref startIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringBuilder.NativeMethodInfoPtr_ToString_Public_String_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001930 RID: 6448 RVA: 0x00093A5C File Offset: 0x00091C5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 312006, XrefRangeEnd = 312007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StringBuilder Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringBuilder.NativeMethodInfoPtr_Clear_Public_StringBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr3) : null;
		}

		// Token: 0x17000504 RID: 1284
		// (get) Token: 0x06001931 RID: 6449 RVA: 0x00093A9C File Offset: 0x00091C9C
		// (set) Token: 0x06001932 RID: 6450 RVA: 0x00093AD8 File Offset: 0x00091CD8
		public unsafe int Length
		{
			[CallerCount(114)]
			[CachedScanResults(RefRangeStart = 312007, RefRangeEnd = 312121, XrefRangeStart = 312007, XrefRangeEnd = 312007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringBuilder.NativeMethodInfoPtr_get_Length_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(39)]
			[CachedScanResults(RefRangeStart = 312122, RefRangeEnd = 312161, XrefRangeStart = 312121, XrefRangeEnd = 312122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringBuilder.NativeMethodInfoPtr_set_Length_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000505 RID: 1285
		// (get) Token: 0x06001933 RID: 6451 RVA: 0x00093B18 File Offset: 0x00091D18
		// (set) Token: 0x06001934 RID: 6452 RVA: 0x00093B64 File Offset: 0x00091D64
		public unsafe char Chars
		{
			[CallerCount(42)]
			[CachedScanResults(RefRangeStart = 312162, RefRangeEnd = 312204, XrefRangeStart = 312161, XrefRangeEnd = 312162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringBuilder.NativeMethodInfoPtr_get_Chars_Public_get_Char_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 312205, RefRangeEnd = 312219, XrefRangeStart = 312204, XrefRangeEnd = 312205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringBuilder.NativeMethodInfoPtr_set_Chars_Public_set_Void_Int32_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001935 RID: 6453 RVA: 0x00093BB0 File Offset: 0x00091DB0
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 312221, RefRangeEnd = 312229, XrefRangeStart = 312219, XrefRangeEnd = 312221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StringBuilder Append(char value, int repeatCount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref repeatCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringBuilder.NativeMethodInfoPtr_Append_Public_StringBuilder_Char_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr3) : null;
		}

		// Token: 0x06001936 RID: 6454 RVA: 0x00093C0C File Offset: 0x00091E0C
		[CallerCount(26)]
		[CachedScanResults(RefRangeStart = 312232, RefRangeEnd = 312258, XrefRangeStart = 312229, XrefRangeEnd = 312232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StringBuilder Append(Il2CppStructArray<char> value, int startIndex, int charCount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref charCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringBuilder.NativeMethodInfoPtr_Append_Public_StringBuilder_Il2CppStructArray_1_Char_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr3) : null;
		}

		// Token: 0x06001937 RID: 6455 RVA: 0x00093C78 File Offset: 0x00091E78
		[CallerCount(717)]
		[CachedScanResults(RefRangeStart = 312260, RefRangeEnd = 312977, XrefRangeStart = 312258, XrefRangeEnd = 312260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StringBuilder Append(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringBuilder.NativeMethodInfoPtr_Append_Public_StringBuilder_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr3) : null;
			}
		}

		// Token: 0x06001938 RID: 6456 RVA: 0x00093CC8 File Offset: 0x00091EC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 312977, XrefRangeEnd = 312980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AppendHelper(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringBuilder.NativeMethodInfoPtr_AppendHelper_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001939 RID: 6457 RVA: 0x00093D0C File Offset: 0x00091F0C
		[CallerCount(24)]
		[CachedScanResults(RefRangeStart = 312984, RefRangeEnd = 313008, XrefRangeStart = 312980, XrefRangeEnd = 312984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StringBuilder Append(string value, int startIndex, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringBuilder.NativeMethodInfoPtr_Append_Public_StringBuilder_String_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr3) : null;
		}

		// Token: 0x0600193A RID: 6458 RVA: 0x00093D78 File Offset: 0x00091F78
		[CallerCount(38)]
		[CachedScanResults(RefRangeStart = 313010, RefRangeEnd = 313048, XrefRangeStart = 313008, XrefRangeEnd = 313010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StringBuilder AppendLine()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringBuilder.NativeMethodInfoPtr_AppendLine_Public_StringBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr3) : null;
		}

		// Token: 0x0600193B RID: 6459 RVA: 0x00093DB8 File Offset: 0x00091FB8
		[CallerCount(33)]
		[CachedScanResults(RefRangeStart = 313051, RefRangeEnd = 313084, XrefRangeStart = 313048, XrefRangeEnd = 313051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StringBuilder AppendLine(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringBuilder.NativeMethodInfoPtr_AppendLine_Public_StringBuilder_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr3) : null;
			}
		}

		// Token: 0x0600193C RID: 6460 RVA: 0x00093E08 File Offset: 0x00092008
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 313112, RefRangeEnd = 313114, XrefRangeStart = 313084, XrefRangeEnd = 313112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StringBuilder Insert(int index, string value, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringBuilder.NativeMethodInfoPtr_Insert_Public_StringBuilder_Int32_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr3) : null;
		}

		// Token: 0x0600193D RID: 6461 RVA: 0x00093E74 File Offset: 0x00092074
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 313115, RefRangeEnd = 313125, XrefRangeStart = 313114, XrefRangeEnd = 313115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StringBuilder Remove(int startIndex, int length)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref startIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringBuilder.NativeMethodInfoPtr_Remove_Public_StringBuilder_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr3) : null;
		}

		// Token: 0x0600193E RID: 6462 RVA: 0x00093ED0 File Offset: 0x000920D0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 313131, RefRangeEnd = 313134, XrefRangeStart = 313125, XrefRangeEnd = 313131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StringBuilder Append(byte value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringBuilder.NativeMethodInfoPtr_Append_Public_StringBuilder_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr3) : null;
			}
		}

		// Token: 0x0600193F RID: 6463 RVA: 0x00093F1C File Offset: 0x0009211C
		[CallerCount(259)]
		[CachedScanResults(RefRangeStart = 313136, RefRangeEnd = 313395, XrefRangeStart = 313134, XrefRangeEnd = 313136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StringBuilder Append(char value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringBuilder.NativeMethodInfoPtr_Append_Public_StringBuilder_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr3) : null;
			}
		}

		// Token: 0x06001940 RID: 6464 RVA: 0x00093F68 File Offset: 0x00092168
		[CallerCount(30)]
		[CachedScanResults(RefRangeStart = 313401, RefRangeEnd = 313431, XrefRangeStart = 313395, XrefRangeEnd = 313401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StringBuilder Append(int value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringBuilder.NativeMethodInfoPtr_Append_Public_StringBuilder_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr3) : null;
			}
		}

		// Token: 0x06001941 RID: 6465 RVA: 0x00093FB4 File Offset: 0x000921B4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 313437, RefRangeEnd = 313441, XrefRangeStart = 313431, XrefRangeEnd = 313437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StringBuilder Append(long value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringBuilder.NativeMethodInfoPtr_Append_Public_StringBuilder_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr3) : null;
			}
		}

		// Token: 0x06001942 RID: 6466 RVA: 0x00094000 File Offset: 0x00092200
		[CallerCount(22)]
		[CachedScanResults(RefRangeStart = 313442, RefRangeEnd = 313464, XrefRangeStart = 313441, XrefRangeEnd = 313442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StringBuilder Append(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringBuilder.NativeMethodInfoPtr_Append_Public_StringBuilder_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr3) : null;
			}
		}

		// Token: 0x06001943 RID: 6467 RVA: 0x00094050 File Offset: 0x00092250
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 313465, RefRangeEnd = 313470, XrefRangeStart = 313464, XrefRangeEnd = 313465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StringBuilder Append(Il2CppStructArray<char> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringBuilder.NativeMethodInfoPtr_Append_Public_StringBuilder_Il2CppStructArray_1_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr3) : null;
			}
		}

		// Token: 0x06001944 RID: 6468 RVA: 0x000940A0 File Offset: 0x000922A0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 313472, RefRangeEnd = 313475, XrefRangeStart = 313470, XrefRangeEnd = 313472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StringBuilder Insert(int index, string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringBuilder.NativeMethodInfoPtr_Insert_Public_StringBuilder_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr3) : null;
		}

		// Token: 0x06001945 RID: 6469 RVA: 0x00094100 File Offset: 0x00092300
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 313476, RefRangeEnd = 313484, XrefRangeStart = 313475, XrefRangeEnd = 313476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StringBuilder Insert(int index, char value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringBuilder.NativeMethodInfoPtr_Insert_Public_StringBuilder_Int32_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr3) : null;
		}

		// Token: 0x06001946 RID: 6470 RVA: 0x0009415C File Offset: 0x0009235C
		[CallerCount(24)]
		[CachedScanResults(RefRangeStart = 313486, RefRangeEnd = 313510, XrefRangeStart = 313484, XrefRangeEnd = 313486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StringBuilder AppendFormat(string format, Object arg0)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arg0);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringBuilder.NativeMethodInfoPtr_AppendFormat_Public_StringBuilder_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr3) : null;
		}

		// Token: 0x06001947 RID: 6471 RVA: 0x000941C0 File Offset: 0x000923C0
		[CallerCount(33)]
		[CachedScanResults(RefRangeStart = 313512, RefRangeEnd = 313545, XrefRangeStart = 313510, XrefRangeEnd = 313512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StringBuilder AppendFormat(string format, Object arg0, Object arg1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arg0);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arg1);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringBuilder.NativeMethodInfoPtr_AppendFormat_Public_StringBuilder_String_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr3) : null;
		}

		// Token: 0x06001948 RID: 6472 RVA: 0x00094234 File Offset: 0x00092434
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 313547, RefRangeEnd = 313551, XrefRangeStart = 313545, XrefRangeEnd = 313547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StringBuilder AppendFormat(string format, Object arg0, Object arg1, Object arg2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arg0);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arg1);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arg2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringBuilder.NativeMethodInfoPtr_AppendFormat_Public_StringBuilder_String_Object_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr3) : null;
		}

		// Token: 0x06001949 RID: 6473 RVA: 0x000942BC File Offset: 0x000924BC
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 313553, RefRangeEnd = 313559, XrefRangeStart = 313551, XrefRangeEnd = 313553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StringBuilder AppendFormat(string format, [Optional] Il2CppReferenceArray<Object> args)
		{
			if (args == null)
			{
				args = new Il2CppReferenceArray<Object>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringBuilder.NativeMethodInfoPtr_AppendFormat_Public_StringBuilder_String_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr3) : null;
		}

		// Token: 0x0600194A RID: 6474 RVA: 0x0009432C File Offset: 0x0009252C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 313561, RefRangeEnd = 313563, XrefRangeStart = 313559, XrefRangeEnd = 313561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StringBuilder AppendFormat(IFormatProvider provider, string format, Object arg0)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(format);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arg0);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringBuilder.NativeMethodInfoPtr_AppendFormat_Public_StringBuilder_IFormatProvider_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr3) : null;
		}

		// Token: 0x0600194B RID: 6475 RVA: 0x000943A0 File Offset: 0x000925A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 313563, XrefRangeEnd = 313565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StringBuilder AppendFormat(IFormatProvider provider, string format, Object arg0, Object arg1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(format);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arg0);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arg1);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringBuilder.NativeMethodInfoPtr_AppendFormat_Public_StringBuilder_IFormatProvider_String_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr3) : null;
		}

		// Token: 0x0600194C RID: 6476 RVA: 0x00094428 File Offset: 0x00092628
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 313565, XrefRangeEnd = 313572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void FormatError()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringBuilder.NativeMethodInfoPtr_FormatError_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600194D RID: 6477 RVA: 0x00094450 File Offset: 0x00092650
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 313627, RefRangeEnd = 313643, XrefRangeStart = 313572, XrefRangeEnd = 313627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StringBuilder AppendFormatHelper(IFormatProvider provider, string format, ParamsArray args)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(format);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(args));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringBuilder.NativeMethodInfoPtr_AppendFormatHelper_Internal_StringBuilder_IFormatProvider_String_ParamsArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr3) : null;
		}

		// Token: 0x0600194E RID: 6478 RVA: 0x000944CC File Offset: 0x000926CC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 313644, RefRangeEnd = 313649, XrefRangeStart = 313643, XrefRangeEnd = 313644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StringBuilder Replace(string oldValue, string newValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(oldValue);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(newValue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringBuilder.NativeMethodInfoPtr_Replace_Public_StringBuilder_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr3) : null;
		}

		// Token: 0x0600194F RID: 6479 RVA: 0x00094530 File Offset: 0x00092730
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 313665, RefRangeEnd = 313666, XrefRangeStart = 313649, XrefRangeEnd = 313665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StringBuilder Replace(string oldValue, string newValue, int startIndex, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(oldValue);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(newValue);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringBuilder.NativeMethodInfoPtr_Replace_Public_StringBuilder_String_String_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr3) : null;
		}

		// Token: 0x06001950 RID: 6480 RVA: 0x000945B0 File Offset: 0x000927B0
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 313669, RefRangeEnd = 313675, XrefRangeStart = 313666, XrefRangeEnd = 313669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StringBuilder Append(char* value, int valueCount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref valueCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringBuilder.NativeMethodInfoPtr_Append_Public_StringBuilder_ptr_Char_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr3) : null;
		}

		// Token: 0x06001951 RID: 6481 RVA: 0x0009460C File Offset: 0x0009280C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 313700, RefRangeEnd = 313702, XrefRangeStart = 313675, XrefRangeEnd = 313700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Insert(int index, char* value, int valueCount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = value;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref valueCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringBuilder.NativeMethodInfoPtr_Insert_Private_Void_Int32_ptr_Char_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001952 RID: 6482 RVA: 0x00094668 File Offset: 0x00092868
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 313709, RefRangeEnd = 313710, XrefRangeStart = 313702, XrefRangeEnd = 313709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReplaceAllInChunk(Il2CppStructArray<int> replacements, int replacementsCount, StringBuilder sourceChunk, int removeCount, string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(replacements);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref replacementsCount;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sourceChunk);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref removeCount;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringBuilder.NativeMethodInfoPtr_ReplaceAllInChunk_Private_Void_Il2CppStructArray_1_Int32_Int32_StringBuilder_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001953 RID: 6483 RVA: 0x000946EC File Offset: 0x000928EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 313710, XrefRangeEnd = 313713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool StartsWith(StringBuilder chunk, int indexInChunk, int count, string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(chunk);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref indexInChunk;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringBuilder.NativeMethodInfoPtr_StartsWith_Private_Boolean_StringBuilder_Int32_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001954 RID: 6484 RVA: 0x00094768 File Offset: 0x00092968
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 313720, RefRangeEnd = 313722, XrefRangeStart = 313713, XrefRangeEnd = 313720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReplaceInPlaceAtChunk(ref StringBuilder chunk, ref int indexInChunk, char* value, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(chunk);
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &indexInChunk;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = value;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(StringBuilder.NativeMethodInfoPtr_ReplaceInPlaceAtChunk_Private_Void_byref_StringBuilder_byref_Int32_ptr_Char_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			chunk = ((intPtr4 == 0) ? null : new StringBuilder(intPtr4));
		}

		// Token: 0x06001955 RID: 6485 RVA: 0x000947E8 File Offset: 0x000929E8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 313723, RefRangeEnd = 313728, XrefRangeStart = 313722, XrefRangeEnd = 313723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ThreadSafeCopy(char* sourcePtr, Il2CppStructArray<char> destination, int destinationIndex, int count)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = sourcePtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(destination);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref destinationIndex;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringBuilder.NativeMethodInfoPtr_ThreadSafeCopy_Private_Static_Void_ptr_Char_Il2CppStructArray_1_Char_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001956 RID: 6486 RVA: 0x00094848 File Offset: 0x00092A48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 313728, XrefRangeEnd = 313729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ThreadSafeCopy(Il2CppStructArray<char> source, int sourceIndex, Il2CppStructArray<char> destination, int destinationIndex, int count)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sourceIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(destination);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref destinationIndex;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringBuilder.NativeMethodInfoPtr_ThreadSafeCopy_Private_Static_Void_Il2CppStructArray_1_Char_Int32_Il2CppStructArray_1_Char_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001957 RID: 6487 RVA: 0x000948BC File Offset: 0x00092ABC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 313729, XrefRangeEnd = 313730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StringBuilder FindChunkForIndex(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringBuilder.NativeMethodInfoPtr_FindChunkForIndex_Private_StringBuilder_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr3) : null;
			}
		}

		// Token: 0x06001958 RID: 6488 RVA: 0x00094908 File Offset: 0x00092B08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 313730, XrefRangeEnd = 313731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StringBuilder Next(StringBuilder chunk)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(chunk);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringBuilder.NativeMethodInfoPtr_Next_Private_StringBuilder_StringBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr3) : null;
			}
		}

		// Token: 0x06001959 RID: 6489 RVA: 0x00094958 File Offset: 0x00092B58
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 313743, RefRangeEnd = 313746, XrefRangeStart = 313731, XrefRangeEnd = 313743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ExpandByABlock(int minBlockCharCount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref minBlockCharCount;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringBuilder.NativeMethodInfoPtr_ExpandByABlock_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600195A RID: 6490 RVA: 0x00094998 File Offset: 0x00092B98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 313746, XrefRangeEnd = 313747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StringBuilder(StringBuilder from)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StringBuilder>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(from);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringBuilder.NativeMethodInfoPtr__ctor_Private_Void_StringBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600195B RID: 6491 RVA: 0x000949E4 File Offset: 0x00092BE4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 313750, RefRangeEnd = 313751, XrefRangeStart = 313747, XrefRangeEnd = 313750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MakeRoom(int index, int count, out StringBuilder chunk, out int indexInChunk, bool doneMoveFollowingChars)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &indexInChunk;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref doneMoveFollowingChars;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(StringBuilder.NativeMethodInfoPtr_MakeRoom_Private_Void_Int32_Int32_byref_StringBuilder_byref_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			chunk = ((intPtr4 == 0) ? null : new StringBuilder(intPtr4));
		}

		// Token: 0x0600195C RID: 6492 RVA: 0x00094A70 File Offset: 0x00092C70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 313751, XrefRangeEnd = 313755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StringBuilder(int size, int maxCapacity, StringBuilder previousBlock)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StringBuilder>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref size;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxCapacity;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(previousBlock);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringBuilder.NativeMethodInfoPtr__ctor_Private_Void_Int32_Int32_StringBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600195D RID: 6493 RVA: 0x00094AD8 File Offset: 0x00092CD8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 313759, RefRangeEnd = 313760, XrefRangeStart = 313755, XrefRangeEnd = 313759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Remove(int startIndex, int count, out StringBuilder chunk, out int indexInChunk)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref startIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &indexInChunk;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(StringBuilder.NativeMethodInfoPtr_Remove_Private_Void_Int32_Int32_byref_StringBuilder_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			chunk = ((intPtr4 == 0) ? null : new StringBuilder(intPtr4));
		}

		// Token: 0x0600195E RID: 6494 RVA: 0x00008C0F File Offset: 0x00006E0F
		public StringBuilder AppendFormat(string format, params Object[] args)
		{
			return this.AppendFormat(format, new Il2CppReferenceArray<Object>(args));
		}

		// Token: 0x0600195F RID: 6495 RVA: 0x00008C1E File Offset: 0x00006E1E
		public StringBuilder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004F7 RID: 1271
		// (get) Token: 0x06001960 RID: 6496 RVA: 0x00094B54 File Offset: 0x00092D54
		// (set) Token: 0x06001961 RID: 6497 RVA: 0x00008C27 File Offset: 0x00006E27
		public unsafe Il2CppStructArray<char> m_ChunkChars
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringBuilder.NativeFieldInfoPtr_m_ChunkChars);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringBuilder.NativeFieldInfoPtr_m_ChunkChars), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004F8 RID: 1272
		// (get) Token: 0x06001962 RID: 6498 RVA: 0x00094B84 File Offset: 0x00092D84
		// (set) Token: 0x06001963 RID: 6499 RVA: 0x00008C46 File Offset: 0x00006E46
		public unsafe StringBuilder m_ChunkPrevious
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringBuilder.NativeFieldInfoPtr_m_ChunkPrevious);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringBuilder.NativeFieldInfoPtr_m_ChunkPrevious), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004F9 RID: 1273
		// (get) Token: 0x06001964 RID: 6500 RVA: 0x00094BB4 File Offset: 0x00092DB4
		// (set) Token: 0x06001965 RID: 6501 RVA: 0x00008C65 File Offset: 0x00006E65
		public unsafe int m_ChunkLength
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringBuilder.NativeFieldInfoPtr_m_ChunkLength);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringBuilder.NativeFieldInfoPtr_m_ChunkLength)) = value;
			}
		}

		// Token: 0x170004FA RID: 1274
		// (get) Token: 0x06001966 RID: 6502 RVA: 0x00094BDC File Offset: 0x00092DDC
		// (set) Token: 0x06001967 RID: 6503 RVA: 0x00008C80 File Offset: 0x00006E80
		public unsafe int m_ChunkOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringBuilder.NativeFieldInfoPtr_m_ChunkOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringBuilder.NativeFieldInfoPtr_m_ChunkOffset)) = value;
			}
		}

		// Token: 0x170004FB RID: 1275
		// (get) Token: 0x06001968 RID: 6504 RVA: 0x00094C04 File Offset: 0x00092E04
		// (set) Token: 0x06001969 RID: 6505 RVA: 0x00008C9B File Offset: 0x00006E9B
		public unsafe int m_MaxCapacity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringBuilder.NativeFieldInfoPtr_m_MaxCapacity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringBuilder.NativeFieldInfoPtr_m_MaxCapacity)) = value;
			}
		}

		// Token: 0x170004FC RID: 1276
		// (get) Token: 0x0600196A RID: 6506 RVA: 0x00094C2C File Offset: 0x00092E2C
		// (set) Token: 0x0600196B RID: 6507 RVA: 0x00008CB6 File Offset: 0x00006EB6
		public unsafe static int DefaultCapacity
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(StringBuilder.NativeFieldInfoPtr_DefaultCapacity, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StringBuilder.NativeFieldInfoPtr_DefaultCapacity, (void*)(&value));
			}
		}

		// Token: 0x170004FD RID: 1277
		// (get) Token: 0x0600196C RID: 6508 RVA: 0x00094C48 File Offset: 0x00092E48
		// (set) Token: 0x0600196D RID: 6509 RVA: 0x00008CC4 File Offset: 0x00006EC4
		public unsafe static string CapacityField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(StringBuilder.NativeFieldInfoPtr_CapacityField, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StringBuilder.NativeFieldInfoPtr_CapacityField, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170004FE RID: 1278
		// (get) Token: 0x0600196E RID: 6510 RVA: 0x00094C68 File Offset: 0x00092E68
		// (set) Token: 0x0600196F RID: 6511 RVA: 0x00008CD6 File Offset: 0x00006ED6
		public unsafe static string MaxCapacityField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(StringBuilder.NativeFieldInfoPtr_MaxCapacityField, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StringBuilder.NativeFieldInfoPtr_MaxCapacityField, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170004FF RID: 1279
		// (get) Token: 0x06001970 RID: 6512 RVA: 0x00094C88 File Offset: 0x00092E88
		// (set) Token: 0x06001971 RID: 6513 RVA: 0x00008CE8 File Offset: 0x00006EE8
		public unsafe static string StringValueField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(StringBuilder.NativeFieldInfoPtr_StringValueField, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StringBuilder.NativeFieldInfoPtr_StringValueField, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000500 RID: 1280
		// (get) Token: 0x06001972 RID: 6514 RVA: 0x00094CA8 File Offset: 0x00092EA8
		// (set) Token: 0x06001973 RID: 6515 RVA: 0x00008CFA File Offset: 0x00006EFA
		public unsafe static string ThreadIDField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(StringBuilder.NativeFieldInfoPtr_ThreadIDField, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StringBuilder.NativeFieldInfoPtr_ThreadIDField, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000501 RID: 1281
		// (get) Token: 0x06001974 RID: 6516 RVA: 0x00094CC8 File Offset: 0x00092EC8
		// (set) Token: 0x06001975 RID: 6517 RVA: 0x00008D0C File Offset: 0x00006F0C
		public unsafe static int MaxChunkSize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(StringBuilder.NativeFieldInfoPtr_MaxChunkSize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StringBuilder.NativeFieldInfoPtr_MaxChunkSize, (void*)(&value));
			}
		}

		// Token: 0x040016F8 RID: 5880
		private static readonly IntPtr NativeFieldInfoPtr_m_ChunkChars;

		// Token: 0x040016F9 RID: 5881
		private static readonly IntPtr NativeFieldInfoPtr_m_ChunkPrevious;

		// Token: 0x040016FA RID: 5882
		private static readonly IntPtr NativeFieldInfoPtr_m_ChunkLength;

		// Token: 0x040016FB RID: 5883
		private static readonly IntPtr NativeFieldInfoPtr_m_ChunkOffset;

		// Token: 0x040016FC RID: 5884
		private static readonly IntPtr NativeFieldInfoPtr_m_MaxCapacity;

		// Token: 0x040016FD RID: 5885
		private static readonly IntPtr NativeFieldInfoPtr_DefaultCapacity;

		// Token: 0x040016FE RID: 5886
		private static readonly IntPtr NativeFieldInfoPtr_CapacityField;

		// Token: 0x040016FF RID: 5887
		private static readonly IntPtr NativeFieldInfoPtr_MaxCapacityField;

		// Token: 0x04001700 RID: 5888
		private static readonly IntPtr NativeFieldInfoPtr_StringValueField;

		// Token: 0x04001701 RID: 5889
		private static readonly IntPtr NativeFieldInfoPtr_ThreadIDField;

		// Token: 0x04001702 RID: 5890
		private static readonly IntPtr NativeFieldInfoPtr_MaxChunkSize;

		// Token: 0x04001703 RID: 5891
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001704 RID: 5892
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04001705 RID: 5893
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04001706 RID: 5894
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Int32_0;

		// Token: 0x04001707 RID: 5895
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Int32_Int32_0;

		// Token: 0x04001708 RID: 5896
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04001709 RID: 5897
		private static readonly IntPtr NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x0400170A RID: 5898
		private static readonly IntPtr NativeMethodInfoPtr_get_Capacity_Public_get_Int32_0;

		// Token: 0x0400170B RID: 5899
		private static readonly IntPtr NativeMethodInfoPtr_get_MaxCapacity_Public_get_Int32_0;

		// Token: 0x0400170C RID: 5900
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x0400170D RID: 5901
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_String_Int32_Int32_0;

		// Token: 0x0400170E RID: 5902
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_StringBuilder_0;

		// Token: 0x0400170F RID: 5903
		private static readonly IntPtr NativeMethodInfoPtr_get_Length_Public_get_Int32_0;

		// Token: 0x04001710 RID: 5904
		private static readonly IntPtr NativeMethodInfoPtr_set_Length_Public_set_Void_Int32_0;

		// Token: 0x04001711 RID: 5905
		private static readonly IntPtr NativeMethodInfoPtr_get_Chars_Public_get_Char_Int32_0;

		// Token: 0x04001712 RID: 5906
		private static readonly IntPtr NativeMethodInfoPtr_set_Chars_Public_set_Void_Int32_Char_0;

		// Token: 0x04001713 RID: 5907
		private static readonly IntPtr NativeMethodInfoPtr_Append_Public_StringBuilder_Char_Int32_0;

		// Token: 0x04001714 RID: 5908
		private static readonly IntPtr NativeMethodInfoPtr_Append_Public_StringBuilder_Il2CppStructArray_1_Char_Int32_Int32_0;

		// Token: 0x04001715 RID: 5909
		private static readonly IntPtr NativeMethodInfoPtr_Append_Public_StringBuilder_String_0;

		// Token: 0x04001716 RID: 5910
		private static readonly IntPtr NativeMethodInfoPtr_AppendHelper_Private_Void_String_0;

		// Token: 0x04001717 RID: 5911
		private static readonly IntPtr NativeMethodInfoPtr_Append_Public_StringBuilder_String_Int32_Int32_0;

		// Token: 0x04001718 RID: 5912
		private static readonly IntPtr NativeMethodInfoPtr_AppendLine_Public_StringBuilder_0;

		// Token: 0x04001719 RID: 5913
		private static readonly IntPtr NativeMethodInfoPtr_AppendLine_Public_StringBuilder_String_0;

		// Token: 0x0400171A RID: 5914
		private static readonly IntPtr NativeMethodInfoPtr_Insert_Public_StringBuilder_Int32_String_Int32_0;

		// Token: 0x0400171B RID: 5915
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_StringBuilder_Int32_Int32_0;

		// Token: 0x0400171C RID: 5916
		private static readonly IntPtr NativeMethodInfoPtr_Append_Public_StringBuilder_Byte_0;

		// Token: 0x0400171D RID: 5917
		private static readonly IntPtr NativeMethodInfoPtr_Append_Public_StringBuilder_Char_0;

		// Token: 0x0400171E RID: 5918
		private static readonly IntPtr NativeMethodInfoPtr_Append_Public_StringBuilder_Int32_0;

		// Token: 0x0400171F RID: 5919
		private static readonly IntPtr NativeMethodInfoPtr_Append_Public_StringBuilder_Int64_0;

		// Token: 0x04001720 RID: 5920
		private static readonly IntPtr NativeMethodInfoPtr_Append_Public_StringBuilder_Object_0;

		// Token: 0x04001721 RID: 5921
		private static readonly IntPtr NativeMethodInfoPtr_Append_Public_StringBuilder_Il2CppStructArray_1_Char_0;

		// Token: 0x04001722 RID: 5922
		private static readonly IntPtr NativeMethodInfoPtr_Insert_Public_StringBuilder_Int32_String_0;

		// Token: 0x04001723 RID: 5923
		private static readonly IntPtr NativeMethodInfoPtr_Insert_Public_StringBuilder_Int32_Char_0;

		// Token: 0x04001724 RID: 5924
		private static readonly IntPtr NativeMethodInfoPtr_AppendFormat_Public_StringBuilder_String_Object_0;

		// Token: 0x04001725 RID: 5925
		private static readonly IntPtr NativeMethodInfoPtr_AppendFormat_Public_StringBuilder_String_Object_Object_0;

		// Token: 0x04001726 RID: 5926
		private static readonly IntPtr NativeMethodInfoPtr_AppendFormat_Public_StringBuilder_String_Object_Object_Object_0;

		// Token: 0x04001727 RID: 5927
		private static readonly IntPtr NativeMethodInfoPtr_AppendFormat_Public_StringBuilder_String_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04001728 RID: 5928
		private static readonly IntPtr NativeMethodInfoPtr_AppendFormat_Public_StringBuilder_IFormatProvider_String_Object_0;

		// Token: 0x04001729 RID: 5929
		private static readonly IntPtr NativeMethodInfoPtr_AppendFormat_Public_StringBuilder_IFormatProvider_String_Object_Object_0;

		// Token: 0x0400172A RID: 5930
		private static readonly IntPtr NativeMethodInfoPtr_FormatError_Private_Static_Void_0;

		// Token: 0x0400172B RID: 5931
		private static readonly IntPtr NativeMethodInfoPtr_AppendFormatHelper_Internal_StringBuilder_IFormatProvider_String_ParamsArray_0;

		// Token: 0x0400172C RID: 5932
		private static readonly IntPtr NativeMethodInfoPtr_Replace_Public_StringBuilder_String_String_0;

		// Token: 0x0400172D RID: 5933
		private static readonly IntPtr NativeMethodInfoPtr_Replace_Public_StringBuilder_String_String_Int32_Int32_0;

		// Token: 0x0400172E RID: 5934
		private static readonly IntPtr NativeMethodInfoPtr_Append_Public_StringBuilder_ptr_Char_Int32_0;

		// Token: 0x0400172F RID: 5935
		private static readonly IntPtr NativeMethodInfoPtr_Insert_Private_Void_Int32_ptr_Char_Int32_0;

		// Token: 0x04001730 RID: 5936
		private static readonly IntPtr NativeMethodInfoPtr_ReplaceAllInChunk_Private_Void_Il2CppStructArray_1_Int32_Int32_StringBuilder_Int32_String_0;

		// Token: 0x04001731 RID: 5937
		private static readonly IntPtr NativeMethodInfoPtr_StartsWith_Private_Boolean_StringBuilder_Int32_Int32_String_0;

		// Token: 0x04001732 RID: 5938
		private static readonly IntPtr NativeMethodInfoPtr_ReplaceInPlaceAtChunk_Private_Void_byref_StringBuilder_byref_Int32_ptr_Char_Int32_0;

		// Token: 0x04001733 RID: 5939
		private static readonly IntPtr NativeMethodInfoPtr_ThreadSafeCopy_Private_Static_Void_ptr_Char_Il2CppStructArray_1_Char_Int32_Int32_0;

		// Token: 0x04001734 RID: 5940
		private static readonly IntPtr NativeMethodInfoPtr_ThreadSafeCopy_Private_Static_Void_Il2CppStructArray_1_Char_Int32_Il2CppStructArray_1_Char_Int32_Int32_0;

		// Token: 0x04001735 RID: 5941
		private static readonly IntPtr NativeMethodInfoPtr_FindChunkForIndex_Private_StringBuilder_Int32_0;

		// Token: 0x04001736 RID: 5942
		private static readonly IntPtr NativeMethodInfoPtr_Next_Private_StringBuilder_StringBuilder_0;

		// Token: 0x04001737 RID: 5943
		private static readonly IntPtr NativeMethodInfoPtr_ExpandByABlock_Private_Void_Int32_0;

		// Token: 0x04001738 RID: 5944
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_StringBuilder_0;

		// Token: 0x04001739 RID: 5945
		private static readonly IntPtr NativeMethodInfoPtr_MakeRoom_Private_Void_Int32_Int32_byref_StringBuilder_byref_Int32_Boolean_0;

		// Token: 0x0400173A RID: 5946
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_Int32_Int32_StringBuilder_0;

		// Token: 0x0400173B RID: 5947
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Private_Void_Int32_Int32_byref_StringBuilder_byref_Int32_0;
	}
}
