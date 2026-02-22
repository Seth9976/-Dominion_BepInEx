using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Text;

namespace Il2CppSystem.Xml
{
	// Token: 0x02000016 RID: 22
	public class IDtdParserAdapter : Il2CppObjectBase
	{
		// Token: 0x060000C9 RID: 201 RVA: 0x0000B8C0 File Offset: 0x00009AC0
		// Note: this type is marked as 'beforefieldinit'.
		static IDtdParserAdapter()
		{
			Il2CppClassPointerStore<IDtdParserAdapter>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "IDtdParserAdapter");
			IDtdParserAdapter.NativeMethodInfoPtr_get_NameTable_Public_Abstract_Virtual_New_get_XmlNameTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDtdParserAdapter>.NativeClassPtr, 100663393);
			IDtdParserAdapter.NativeMethodInfoPtr_get_NamespaceResolver_Public_Abstract_Virtual_New_get_IXmlNamespaceResolver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDtdParserAdapter>.NativeClassPtr, 100663394);
			IDtdParserAdapter.NativeMethodInfoPtr_get_BaseUri_Public_Abstract_Virtual_New_get_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDtdParserAdapter>.NativeClassPtr, 100663395);
			IDtdParserAdapter.NativeMethodInfoPtr_get_ParsingBuffer_Public_Abstract_Virtual_New_get_Il2CppStructArray_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDtdParserAdapter>.NativeClassPtr, 100663396);
			IDtdParserAdapter.NativeMethodInfoPtr_get_ParsingBufferLength_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDtdParserAdapter>.NativeClassPtr, 100663397);
			IDtdParserAdapter.NativeMethodInfoPtr_get_CurrentPosition_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDtdParserAdapter>.NativeClassPtr, 100663398);
			IDtdParserAdapter.NativeMethodInfoPtr_set_CurrentPosition_Public_Abstract_Virtual_New_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDtdParserAdapter>.NativeClassPtr, 100663399);
			IDtdParserAdapter.NativeMethodInfoPtr_get_LineNo_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDtdParserAdapter>.NativeClassPtr, 100663400);
			IDtdParserAdapter.NativeMethodInfoPtr_get_LineStartPosition_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDtdParserAdapter>.NativeClassPtr, 100663401);
			IDtdParserAdapter.NativeMethodInfoPtr_get_IsEof_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDtdParserAdapter>.NativeClassPtr, 100663402);
			IDtdParserAdapter.NativeMethodInfoPtr_get_EntityStackLength_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDtdParserAdapter>.NativeClassPtr, 100663403);
			IDtdParserAdapter.NativeMethodInfoPtr_get_IsEntityEolNormalized_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDtdParserAdapter>.NativeClassPtr, 100663404);
			IDtdParserAdapter.NativeMethodInfoPtr_ReadData_Public_Abstract_Virtual_New_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDtdParserAdapter>.NativeClassPtr, 100663405);
			IDtdParserAdapter.NativeMethodInfoPtr_OnNewLine_Public_Abstract_Virtual_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDtdParserAdapter>.NativeClassPtr, 100663406);
			IDtdParserAdapter.NativeMethodInfoPtr_ParseNumericCharRef_Public_Abstract_Virtual_New_Int32_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDtdParserAdapter>.NativeClassPtr, 100663407);
			IDtdParserAdapter.NativeMethodInfoPtr_ParseNamedCharRef_Public_Abstract_Virtual_New_Int32_Boolean_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDtdParserAdapter>.NativeClassPtr, 100663408);
			IDtdParserAdapter.NativeMethodInfoPtr_ParsePI_Public_Abstract_Virtual_New_Void_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDtdParserAdapter>.NativeClassPtr, 100663409);
			IDtdParserAdapter.NativeMethodInfoPtr_ParseComment_Public_Abstract_Virtual_New_Void_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDtdParserAdapter>.NativeClassPtr, 100663410);
			IDtdParserAdapter.NativeMethodInfoPtr_PushEntity_Public_Abstract_Virtual_New_Boolean_IDtdEntityInfo_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDtdParserAdapter>.NativeClassPtr, 100663411);
			IDtdParserAdapter.NativeMethodInfoPtr_PopEntity_Public_Abstract_Virtual_New_Boolean_byref_IDtdEntityInfo_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDtdParserAdapter>.NativeClassPtr, 100663412);
			IDtdParserAdapter.NativeMethodInfoPtr_PushExternalSubset_Public_Abstract_Virtual_New_Boolean_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDtdParserAdapter>.NativeClassPtr, 100663413);
			IDtdParserAdapter.NativeMethodInfoPtr_PushInternalDtd_Public_Abstract_Virtual_New_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDtdParserAdapter>.NativeClassPtr, 100663414);
			IDtdParserAdapter.NativeMethodInfoPtr_OnSystemId_Public_Abstract_Virtual_New_Void_String_LineInfo_LineInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDtdParserAdapter>.NativeClassPtr, 100663415);
			IDtdParserAdapter.NativeMethodInfoPtr_OnPublicId_Public_Abstract_Virtual_New_Void_String_LineInfo_LineInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDtdParserAdapter>.NativeClassPtr, 100663416);
			IDtdParserAdapter.NativeMethodInfoPtr_Throw_Public_Abstract_Virtual_New_Void_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDtdParserAdapter>.NativeClassPtr, 100663417);
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x060000CA RID: 202 RVA: 0x0000BADC File Offset: 0x00009CDC
		public unsafe virtual XmlNameTable NameTable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDtdParserAdapter.NativeMethodInfoPtr_get_NameTable_Public_Abstract_Virtual_New_get_XmlNameTable_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlNameTable>(intPtr3) : null;
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x060000CB RID: 203 RVA: 0x0000BB28 File Offset: 0x00009D28
		public unsafe virtual IXmlNamespaceResolver NamespaceResolver
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDtdParserAdapter.NativeMethodInfoPtr_get_NamespaceResolver_Public_Abstract_Virtual_New_get_IXmlNamespaceResolver_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IXmlNamespaceResolver>(intPtr3) : null;
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x060000CC RID: 204 RVA: 0x0000BB74 File Offset: 0x00009D74
		public unsafe virtual Uri BaseUri
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDtdParserAdapter.NativeMethodInfoPtr_get_BaseUri_Public_Abstract_Virtual_New_get_Uri_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Uri>(intPtr3) : null;
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x060000CD RID: 205 RVA: 0x0000BBC0 File Offset: 0x00009DC0
		public unsafe virtual Il2CppStructArray<char> ParsingBuffer
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDtdParserAdapter.NativeMethodInfoPtr_get_ParsingBuffer_Public_Abstract_Virtual_New_get_Il2CppStructArray_1_Char_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr3) : null;
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x060000CE RID: 206 RVA: 0x0000BC0C File Offset: 0x00009E0C
		public unsafe virtual int ParsingBufferLength
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDtdParserAdapter.NativeMethodInfoPtr_get_ParsingBufferLength_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x060000CF RID: 207 RVA: 0x0000BC54 File Offset: 0x00009E54
		// (set) Token: 0x060000D0 RID: 208 RVA: 0x0000BC9C File Offset: 0x00009E9C
		public unsafe virtual int CurrentPosition
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDtdParserAdapter.NativeMethodInfoPtr_get_CurrentPosition_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDtdParserAdapter.NativeMethodInfoPtr_set_CurrentPosition_Public_Abstract_Virtual_New_set_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x060000D1 RID: 209 RVA: 0x0000BCE8 File Offset: 0x00009EE8
		public unsafe virtual int LineNo
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDtdParserAdapter.NativeMethodInfoPtr_get_LineNo_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x060000D2 RID: 210 RVA: 0x0000BD30 File Offset: 0x00009F30
		public unsafe virtual int LineStartPosition
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDtdParserAdapter.NativeMethodInfoPtr_get_LineStartPosition_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x060000D3 RID: 211 RVA: 0x0000BD78 File Offset: 0x00009F78
		public unsafe virtual bool IsEof
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDtdParserAdapter.NativeMethodInfoPtr_get_IsEof_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x060000D4 RID: 212 RVA: 0x0000BDC0 File Offset: 0x00009FC0
		public unsafe virtual int EntityStackLength
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDtdParserAdapter.NativeMethodInfoPtr_get_EntityStackLength_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x060000D5 RID: 213 RVA: 0x0000BE08 File Offset: 0x0000A008
		public unsafe virtual bool IsEntityEolNormalized
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDtdParserAdapter.NativeMethodInfoPtr_get_IsEntityEolNormalized_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x0000BE50 File Offset: 0x0000A050
		[CallerCount(0)]
		public unsafe virtual int ReadData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDtdParserAdapter.NativeMethodInfoPtr_ReadData_Public_Abstract_Virtual_New_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x0000BE98 File Offset: 0x0000A098
		[CallerCount(0)]
		public unsafe virtual void OnNewLine(int pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDtdParserAdapter.NativeMethodInfoPtr_OnNewLine_Public_Abstract_Virtual_New_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x0000BEE4 File Offset: 0x0000A0E4
		[CallerCount(0)]
		public unsafe virtual int ParseNumericCharRef(StringBuilder internalSubsetBuilder)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(internalSubsetBuilder);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDtdParserAdapter.NativeMethodInfoPtr_ParseNumericCharRef_Public_Abstract_Virtual_New_Int32_StringBuilder_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x0000BF3C File Offset: 0x0000A13C
		[CallerCount(0)]
		public unsafe virtual int ParseNamedCharRef(bool expand, StringBuilder internalSubsetBuilder)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref expand;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(internalSubsetBuilder);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDtdParserAdapter.NativeMethodInfoPtr_ParseNamedCharRef_Public_Abstract_Virtual_New_Int32_Boolean_StringBuilder_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000DA RID: 218 RVA: 0x0000BFA4 File Offset: 0x0000A1A4
		[CallerCount(0)]
		public unsafe virtual void ParsePI(StringBuilder sb)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sb);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDtdParserAdapter.NativeMethodInfoPtr_ParsePI_Public_Abstract_Virtual_New_Void_StringBuilder_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000DB RID: 219 RVA: 0x0000BFF4 File Offset: 0x0000A1F4
		[CallerCount(0)]
		public unsafe virtual void ParseComment(StringBuilder sb)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sb);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDtdParserAdapter.NativeMethodInfoPtr_ParseComment_Public_Abstract_Virtual_New_Void_StringBuilder_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000DC RID: 220 RVA: 0x0000C044 File Offset: 0x0000A244
		[CallerCount(0)]
		public unsafe virtual bool PushEntity(IDtdEntityInfo entity, out int entityId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &entityId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDtdParserAdapter.NativeMethodInfoPtr_PushEntity_Public_Abstract_Virtual_New_Boolean_IDtdEntityInfo_byref_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000DD RID: 221 RVA: 0x0000C0AC File Offset: 0x0000A2AC
		[CallerCount(0)]
		public unsafe virtual bool PopEntity(out IDtdEntityInfo oldEntity, out int newEntityId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = 0;
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &newEntityId;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDtdParserAdapter.NativeMethodInfoPtr_PopEntity_Public_Abstract_Virtual_New_Boolean_byref_IDtdEntityInfo_byref_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			oldEntity = ((intPtr4 == 0) ? null : new IDtdEntityInfo(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060000DE RID: 222 RVA: 0x0000C124 File Offset: 0x0000A324
		[CallerCount(0)]
		public unsafe virtual bool PushExternalSubset(string systemId, string publicId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(systemId);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(publicId);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDtdParserAdapter.NativeMethodInfoPtr_PushExternalSubset_Public_Abstract_Virtual_New_Boolean_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000DF RID: 223 RVA: 0x0000C190 File Offset: 0x0000A390
		[CallerCount(0)]
		public unsafe virtual void PushInternalDtd(string baseUri, string internalDtd)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(baseUri);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(internalDtd);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDtdParserAdapter.NativeMethodInfoPtr_PushInternalDtd_Public_Abstract_Virtual_New_Void_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x0000C1F0 File Offset: 0x0000A3F0
		[CallerCount(0)]
		public unsafe virtual void OnSystemId(string systemId, LineInfo keywordLineInfo, LineInfo systemLiteralLineInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(systemId);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref keywordLineInfo;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref systemLiteralLineInfo;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDtdParserAdapter.NativeMethodInfoPtr_OnSystemId_Public_Abstract_Virtual_New_Void_String_LineInfo_LineInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x0000C25C File Offset: 0x0000A45C
		[CallerCount(0)]
		public unsafe virtual void OnPublicId(string publicId, LineInfo keywordLineInfo, LineInfo publicLiteralLineInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(publicId);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref keywordLineInfo;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref publicLiteralLineInfo;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDtdParserAdapter.NativeMethodInfoPtr_OnPublicId_Public_Abstract_Virtual_New_Void_String_LineInfo_LineInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x0000C2C8 File Offset: 0x0000A4C8
		[CallerCount(0)]
		public unsafe virtual void Throw(Exception e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDtdParserAdapter.NativeMethodInfoPtr_Throw_Public_Abstract_Virtual_New_Void_Exception_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x000024AA File Offset: 0x000006AA
		public IDtdParserAdapter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400008C RID: 140
		private static readonly IntPtr NativeMethodInfoPtr_get_NameTable_Public_Abstract_Virtual_New_get_XmlNameTable_0;

		// Token: 0x0400008D RID: 141
		private static readonly IntPtr NativeMethodInfoPtr_get_NamespaceResolver_Public_Abstract_Virtual_New_get_IXmlNamespaceResolver_0;

		// Token: 0x0400008E RID: 142
		private static readonly IntPtr NativeMethodInfoPtr_get_BaseUri_Public_Abstract_Virtual_New_get_Uri_0;

		// Token: 0x0400008F RID: 143
		private static readonly IntPtr NativeMethodInfoPtr_get_ParsingBuffer_Public_Abstract_Virtual_New_get_Il2CppStructArray_1_Char_0;

		// Token: 0x04000090 RID: 144
		private static readonly IntPtr NativeMethodInfoPtr_get_ParsingBufferLength_Public_Abstract_Virtual_New_get_Int32_0;

		// Token: 0x04000091 RID: 145
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentPosition_Public_Abstract_Virtual_New_get_Int32_0;

		// Token: 0x04000092 RID: 146
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentPosition_Public_Abstract_Virtual_New_set_Void_Int32_0;

		// Token: 0x04000093 RID: 147
		private static readonly IntPtr NativeMethodInfoPtr_get_LineNo_Public_Abstract_Virtual_New_get_Int32_0;

		// Token: 0x04000094 RID: 148
		private static readonly IntPtr NativeMethodInfoPtr_get_LineStartPosition_Public_Abstract_Virtual_New_get_Int32_0;

		// Token: 0x04000095 RID: 149
		private static readonly IntPtr NativeMethodInfoPtr_get_IsEof_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x04000096 RID: 150
		private static readonly IntPtr NativeMethodInfoPtr_get_EntityStackLength_Public_Abstract_Virtual_New_get_Int32_0;

		// Token: 0x04000097 RID: 151
		private static readonly IntPtr NativeMethodInfoPtr_get_IsEntityEolNormalized_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x04000098 RID: 152
		private static readonly IntPtr NativeMethodInfoPtr_ReadData_Public_Abstract_Virtual_New_Int32_0;

		// Token: 0x04000099 RID: 153
		private static readonly IntPtr NativeMethodInfoPtr_OnNewLine_Public_Abstract_Virtual_New_Void_Int32_0;

		// Token: 0x0400009A RID: 154
		private static readonly IntPtr NativeMethodInfoPtr_ParseNumericCharRef_Public_Abstract_Virtual_New_Int32_StringBuilder_0;

		// Token: 0x0400009B RID: 155
		private static readonly IntPtr NativeMethodInfoPtr_ParseNamedCharRef_Public_Abstract_Virtual_New_Int32_Boolean_StringBuilder_0;

		// Token: 0x0400009C RID: 156
		private static readonly IntPtr NativeMethodInfoPtr_ParsePI_Public_Abstract_Virtual_New_Void_StringBuilder_0;

		// Token: 0x0400009D RID: 157
		private static readonly IntPtr NativeMethodInfoPtr_ParseComment_Public_Abstract_Virtual_New_Void_StringBuilder_0;

		// Token: 0x0400009E RID: 158
		private static readonly IntPtr NativeMethodInfoPtr_PushEntity_Public_Abstract_Virtual_New_Boolean_IDtdEntityInfo_byref_Int32_0;

		// Token: 0x0400009F RID: 159
		private static readonly IntPtr NativeMethodInfoPtr_PopEntity_Public_Abstract_Virtual_New_Boolean_byref_IDtdEntityInfo_byref_Int32_0;

		// Token: 0x040000A0 RID: 160
		private static readonly IntPtr NativeMethodInfoPtr_PushExternalSubset_Public_Abstract_Virtual_New_Boolean_String_String_0;

		// Token: 0x040000A1 RID: 161
		private static readonly IntPtr NativeMethodInfoPtr_PushInternalDtd_Public_Abstract_Virtual_New_Void_String_String_0;

		// Token: 0x040000A2 RID: 162
		private static readonly IntPtr NativeMethodInfoPtr_OnSystemId_Public_Abstract_Virtual_New_Void_String_LineInfo_LineInfo_0;

		// Token: 0x040000A3 RID: 163
		private static readonly IntPtr NativeMethodInfoPtr_OnPublicId_Public_Abstract_Virtual_New_Void_String_LineInfo_LineInfo_0;

		// Token: 0x040000A4 RID: 164
		private static readonly IntPtr NativeMethodInfoPtr_Throw_Public_Abstract_Virtual_New_Void_Exception_0;
	}
}
