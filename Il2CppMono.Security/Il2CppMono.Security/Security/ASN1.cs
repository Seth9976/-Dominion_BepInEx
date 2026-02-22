using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;

namespace Il2CppMono.Security
{
	// Token: 0x02000003 RID: 3
	public class ASN1 : Object
	{
		// Token: 0x06000004 RID: 4 RVA: 0x00003980 File Offset: 0x00001B80
		// Note: this type is marked as 'beforefieldinit'.
		static ASN1()
		{
			Il2CppClassPointerStore<ASN1>.NativeClassPtr = IL2CPP.GetIl2CppClass("Mono.Security.dll", "Mono.Security", "ASN1");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ASN1>.NativeClassPtr);
			ASN1.NativeFieldInfoPtr_m_nTag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ASN1>.NativeClassPtr, "m_nTag");
			ASN1.NativeFieldInfoPtr_m_aValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ASN1>.NativeClassPtr, "m_aValue");
			ASN1.NativeFieldInfoPtr_elist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ASN1>.NativeClassPtr, "elist");
			ASN1.NativeMethodInfoPtr__ctor_Public_Void_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ASN1>.NativeClassPtr, 100663298);
			ASN1.NativeMethodInfoPtr__ctor_Public_Void_Byte_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ASN1>.NativeClassPtr, 100663299);
			ASN1.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ASN1>.NativeClassPtr, 100663300);
			ASN1.NativeMethodInfoPtr_get_Count_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ASN1>.NativeClassPtr, 100663301);
			ASN1.NativeMethodInfoPtr_get_Tag_Public_get_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ASN1>.NativeClassPtr, 100663302);
			ASN1.NativeMethodInfoPtr_get_Length_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ASN1>.NativeClassPtr, 100663303);
			ASN1.NativeMethodInfoPtr_get_Value_Public_get_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ASN1>.NativeClassPtr, 100663304);
			ASN1.NativeMethodInfoPtr_set_Value_Public_set_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ASN1>.NativeClassPtr, 100663305);
			ASN1.NativeMethodInfoPtr_CompareArray_Private_Boolean_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ASN1>.NativeClassPtr, 100663306);
			ASN1.NativeMethodInfoPtr_CompareValue_Public_Boolean_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ASN1>.NativeClassPtr, 100663307);
			ASN1.NativeMethodInfoPtr_Add_Public_ASN1_ASN1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ASN1>.NativeClassPtr, 100663308);
			ASN1.NativeMethodInfoPtr_GetBytes_Public_Virtual_New_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ASN1>.NativeClassPtr, 100663309);
			ASN1.NativeMethodInfoPtr_Decode_Protected_Void_Il2CppStructArray_1_Byte_byref_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ASN1>.NativeClassPtr, 100663310);
			ASN1.NativeMethodInfoPtr_DecodeTLV_Protected_Void_Il2CppStructArray_1_Byte_byref_Int32_byref_Byte_byref_Int32_byref_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ASN1>.NativeClassPtr, 100663311);
			ASN1.NativeMethodInfoPtr_get_Item_Public_get_ASN1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ASN1>.NativeClassPtr, 100663312);
			ASN1.NativeMethodInfoPtr_Element_Public_ASN1_Int32_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ASN1>.NativeClassPtr, 100663313);
			ASN1.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ASN1>.NativeClassPtr, 100663314);
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00003B40 File Offset: 0x00001D40
		[CallerCount(38)]
		[CachedScanResults(RefRangeStart = 4513, RefRangeEnd = 4551, XrefRangeStart = 4512, XrefRangeEnd = 4513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ASN1(byte tag)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ASN1>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref tag;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ASN1.NativeMethodInfoPtr__ctor_Public_Void_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00003B88 File Offset: 0x00001D88
		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 4552, RefRangeEnd = 4569, XrefRangeStart = 4551, XrefRangeEnd = 4552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ASN1(byte tag, Il2CppStructArray<byte> data)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ASN1>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref tag;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ASN1.NativeMethodInfoPtr__ctor_Public_Void_Byte_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00003BE4 File Offset: 0x00001DE4
		[CallerCount(30)]
		[CachedScanResults(RefRangeStart = 4576, RefRangeEnd = 4606, XrefRangeStart = 4569, XrefRangeEnd = 4576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ASN1(Il2CppStructArray<byte> data)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ASN1>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ASN1.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000008 RID: 8 RVA: 0x00003C30 File Offset: 0x00001E30
		public unsafe int Count
		{
			[CallerCount(59)]
			[CachedScanResults(RefRangeStart = 4606, RefRangeEnd = 4665, XrefRangeStart = 4606, XrefRangeEnd = 4606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ASN1.NativeMethodInfoPtr_get_Count_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000009 RID: 9 RVA: 0x00003C6C File Offset: 0x00001E6C
		public unsafe byte Tag
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ASN1.NativeMethodInfoPtr_get_Tag_Public_get_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600000A RID: 10 RVA: 0x00003CA8 File Offset: 0x00001EA8
		public unsafe int Length
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 4665, RefRangeEnd = 4672, XrefRangeStart = 4665, XrefRangeEnd = 4665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ASN1.NativeMethodInfoPtr_get_Length_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600000B RID: 11 RVA: 0x00003CE4 File Offset: 0x00001EE4
		// (set) Token: 0x0600000C RID: 12 RVA: 0x00003D24 File Offset: 0x00001F24
		public unsafe Il2CppStructArray<byte> Value
		{
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 4675, RefRangeEnd = 4748, XrefRangeStart = 4672, XrefRangeEnd = 4675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ASN1.NativeMethodInfoPtr_get_Value_Public_get_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 4748, XrefRangeEnd = 4752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ASN1.NativeMethodInfoPtr_set_Value_Public_set_Void_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00003D68 File Offset: 0x00001F68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 4752, XrefRangeEnd = 4753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CompareArray(Il2CppStructArray<byte> array1, Il2CppStructArray<byte> array2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(array2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ASN1.NativeMethodInfoPtr_CompareArray_Private_Boolean_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00003DC8 File Offset: 0x00001FC8
		[CallerCount(30)]
		[CachedScanResults(RefRangeStart = 4754, RefRangeEnd = 4784, XrefRangeStart = 4753, XrefRangeEnd = 4754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CompareValue(Il2CppStructArray<byte> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ASN1.NativeMethodInfoPtr_CompareValue_Public_Boolean_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00003E18 File Offset: 0x00002018
		[CallerCount(35)]
		[CachedScanResults(RefRangeStart = 4788, RefRangeEnd = 4823, XrefRangeStart = 4784, XrefRangeEnd = 4788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ASN1 Add(ASN1 asn1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(asn1);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ASN1.NativeMethodInfoPtr_Add_Public_ASN1_ASN1_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ASN1>(intPtr3) : null;
			}
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00003E68 File Offset: 0x00002068
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 4823, XrefRangeEnd = 4868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Il2CppStructArray<byte> GetBytes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ASN1.NativeMethodInfoPtr_GetBytes_Public_Virtual_New_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00003EB4 File Offset: 0x000020B4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 4878, RefRangeEnd = 4880, XrefRangeStart = 4868, XrefRangeEnd = 4878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Decode(Il2CppStructArray<byte> asn1, ref int anPos, int anLength)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(asn1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &anPos;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref anLength;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ASN1.NativeMethodInfoPtr_Decode_Protected_Void_Il2CppStructArray_1_Byte_byref_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00003F14 File Offset: 0x00002114
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 4880, XrefRangeEnd = 4891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DecodeTLV(Il2CppStructArray<byte> asn1, ref int pos, out byte tag, out int length, out Il2CppStructArray<byte> content)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(asn1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pos;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &tag;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &length;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ASN1.NativeMethodInfoPtr_DecodeTLV_Protected_Void_Il2CppStructArray_1_Byte_byref_Int32_byref_Byte_byref_Int32_byref_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			content = ((intPtr4 == 0) ? null : new Il2CppStructArray<byte>(intPtr4));
		}

		// Token: 0x17000008 RID: 8
		public unsafe ASN1 this[int index]
		{
			[CallerCount(121)]
			[CachedScanResults(RefRangeStart = 4895, RefRangeEnd = 5016, XrefRangeStart = 4891, XrefRangeEnd = 4895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ASN1.NativeMethodInfoPtr_get_Item_Public_get_ASN1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<ASN1>(intPtr3) : null;
				}
			}
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00003FF0 File Offset: 0x000021F0
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 5021, RefRangeEnd = 5032, XrefRangeStart = 5016, XrefRangeEnd = 5021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ASN1 Element(int index, byte anTag)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref anTag;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ASN1.NativeMethodInfoPtr_Element_Public_ASN1_Int32_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ASN1>(intPtr3) : null;
		}

		// Token: 0x06000015 RID: 21 RVA: 0x0000404C File Offset: 0x0000224C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 5032, XrefRangeEnd = 5075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ASN1.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00002092 File Offset: 0x00000292
		public ASN1(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000017 RID: 23 RVA: 0x00004090 File Offset: 0x00002290
		// (set) Token: 0x06000018 RID: 24 RVA: 0x0000209B File Offset: 0x0000029B
		public unsafe byte m_nTag
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ASN1.NativeFieldInfoPtr_m_nTag);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ASN1.NativeFieldInfoPtr_m_nTag)) = value;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000019 RID: 25 RVA: 0x000040B8 File Offset: 0x000022B8
		// (set) Token: 0x0600001A RID: 26 RVA: 0x000020B6 File Offset: 0x000002B6
		public unsafe Il2CppStructArray<byte> m_aValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ASN1.NativeFieldInfoPtr_m_aValue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ASN1.NativeFieldInfoPtr_m_aValue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600001B RID: 27 RVA: 0x000040E8 File Offset: 0x000022E8
		// (set) Token: 0x0600001C RID: 28 RVA: 0x000020D5 File Offset: 0x000002D5
		public unsafe ArrayList elist
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ASN1.NativeFieldInfoPtr_elist);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ASN1.NativeFieldInfoPtr_elist), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000002 RID: 2
		private static readonly IntPtr NativeFieldInfoPtr_m_nTag;

		// Token: 0x04000003 RID: 3
		private static readonly IntPtr NativeFieldInfoPtr_m_aValue;

		// Token: 0x04000004 RID: 4
		private static readonly IntPtr NativeFieldInfoPtr_elist;

		// Token: 0x04000005 RID: 5
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Byte_0;

		// Token: 0x04000006 RID: 6
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Byte_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000007 RID: 7
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000008 RID: 8
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_get_Int32_0;

		// Token: 0x04000009 RID: 9
		private static readonly IntPtr NativeMethodInfoPtr_get_Tag_Public_get_Byte_0;

		// Token: 0x0400000A RID: 10
		private static readonly IntPtr NativeMethodInfoPtr_get_Length_Public_get_Int32_0;

		// Token: 0x0400000B RID: 11
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_get_Il2CppStructArray_1_Byte_0;

		// Token: 0x0400000C RID: 12
		private static readonly IntPtr NativeMethodInfoPtr_set_Value_Public_set_Void_Il2CppStructArray_1_Byte_0;

		// Token: 0x0400000D RID: 13
		private static readonly IntPtr NativeMethodInfoPtr_CompareArray_Private_Boolean_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0;

		// Token: 0x0400000E RID: 14
		private static readonly IntPtr NativeMethodInfoPtr_CompareValue_Public_Boolean_Il2CppStructArray_1_Byte_0;

		// Token: 0x0400000F RID: 15
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_ASN1_ASN1_0;

		// Token: 0x04000010 RID: 16
		private static readonly IntPtr NativeMethodInfoPtr_GetBytes_Public_Virtual_New_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000011 RID: 17
		private static readonly IntPtr NativeMethodInfoPtr_Decode_Protected_Void_Il2CppStructArray_1_Byte_byref_Int32_Int32_0;

		// Token: 0x04000012 RID: 18
		private static readonly IntPtr NativeMethodInfoPtr_DecodeTLV_Protected_Void_Il2CppStructArray_1_Byte_byref_Int32_byref_Byte_byref_Int32_byref_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000013 RID: 19
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_ASN1_Int32_0;

		// Token: 0x04000014 RID: 20
		private static readonly IntPtr NativeMethodInfoPtr_Element_Public_ASN1_Int32_Byte_0;

		// Token: 0x04000015 RID: 21
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
