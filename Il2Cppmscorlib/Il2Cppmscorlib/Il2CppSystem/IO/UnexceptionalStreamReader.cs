using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Text;

namespace Il2CppSystem.IO
{
	// Token: 0x02000222 RID: 546
	public class UnexceptionalStreamReader : StreamReader
	{
		// Token: 0x0600237B RID: 9083 RVA: 0x000C19D4 File Offset: 0x000BFBD4
		// Note: this type is marked as 'beforefieldinit'.
		static UnexceptionalStreamReader()
		{
			Il2CppClassPointerStore<UnexceptionalStreamReader>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.IO", "UnexceptionalStreamReader");
			UnexceptionalStreamReader.NativeFieldInfoPtr_newline = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnexceptionalStreamReader>.NativeClassPtr, "newline");
			UnexceptionalStreamReader.NativeFieldInfoPtr_newlineChar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnexceptionalStreamReader>.NativeClassPtr, "newlineChar");
			UnexceptionalStreamReader.NativeMethodInfoPtr__ctor_Public_Void_Stream_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnexceptionalStreamReader>.NativeClassPtr, 100669244);
			UnexceptionalStreamReader.NativeMethodInfoPtr_Peek_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnexceptionalStreamReader>.NativeClassPtr, 100669245);
			UnexceptionalStreamReader.NativeMethodInfoPtr_Read_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnexceptionalStreamReader>.NativeClassPtr, 100669246);
			UnexceptionalStreamReader.NativeMethodInfoPtr_Read_Public_Virtual_Int32_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnexceptionalStreamReader>.NativeClassPtr, 100669247);
			UnexceptionalStreamReader.NativeMethodInfoPtr_CheckEOL_Private_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnexceptionalStreamReader>.NativeClassPtr, 100669248);
			UnexceptionalStreamReader.NativeMethodInfoPtr_ReadLine_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnexceptionalStreamReader>.NativeClassPtr, 100669249);
			UnexceptionalStreamReader.NativeMethodInfoPtr_ReadToEnd_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnexceptionalStreamReader>.NativeClassPtr, 100669250);
		}

		// Token: 0x0600237C RID: 9084 RVA: 0x000C1AB0 File Offset: 0x000BFCB0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 324422, RefRangeEnd = 324423, XrefRangeStart = 324418, XrefRangeEnd = 324422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnexceptionalStreamReader(Stream stream, Encoding encoding)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnexceptionalStreamReader>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stream);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(encoding);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnexceptionalStreamReader.NativeMethodInfoPtr__ctor_Public_Void_Stream_Encoding_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600237D RID: 9085 RVA: 0x000C1B10 File Offset: 0x000BFD10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 324423, XrefRangeEnd = 324424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int Peek()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnexceptionalStreamReader.NativeMethodInfoPtr_Peek_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600237E RID: 9086 RVA: 0x000C1B58 File Offset: 0x000BFD58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 324424, XrefRangeEnd = 324425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int Read()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnexceptionalStreamReader.NativeMethodInfoPtr_Read_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600237F RID: 9087 RVA: 0x000C1BA0 File Offset: 0x000BFDA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 324425, XrefRangeEnd = 324435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int Read([In] [Out] Il2CppStructArray<char> dest_buffer, int index, int count)
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
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnexceptionalStreamReader.NativeMethodInfoPtr_Read_Public_Virtual_Int32_Il2CppStructArray_1_Char_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			*dest_buffer = ((intPtr4 == 0) ? null : new Il2CppStructArray<char>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06002380 RID: 9088 RVA: 0x000C1C28 File Offset: 0x000BFE28
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 324448, RefRangeEnd = 324449, XrefRangeStart = 324435, XrefRangeEnd = 324448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CheckEOL(char current)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref current;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnexceptionalStreamReader.NativeMethodInfoPtr_CheckEOL_Private_Boolean_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002381 RID: 9089 RVA: 0x000C1C74 File Offset: 0x000BFE74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 324449, XrefRangeEnd = 324450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ReadLine()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnexceptionalStreamReader.NativeMethodInfoPtr_ReadLine_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002382 RID: 9090 RVA: 0x000C1CB8 File Offset: 0x000BFEB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 324450, XrefRangeEnd = 324451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ReadToEnd()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnexceptionalStreamReader.NativeMethodInfoPtr_ReadToEnd_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002383 RID: 9091 RVA: 0x0000BF68 File Offset: 0x0000A168
		public UnexceptionalStreamReader(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000780 RID: 1920
		// (get) Token: 0x06002384 RID: 9092 RVA: 0x000C1CFC File Offset: 0x000BFEFC
		// (set) Token: 0x06002385 RID: 9093 RVA: 0x0000BF71 File Offset: 0x0000A171
		public unsafe static Il2CppStructArray<bool> newline
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UnexceptionalStreamReader.NativeFieldInfoPtr_newline, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<bool>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UnexceptionalStreamReader.NativeFieldInfoPtr_newline, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000781 RID: 1921
		// (get) Token: 0x06002386 RID: 9094 RVA: 0x000C1D24 File Offset: 0x000BFF24
		// (set) Token: 0x06002387 RID: 9095 RVA: 0x0000BF83 File Offset: 0x0000A183
		public unsafe static char newlineChar
		{
			get
			{
				char c;
				IL2CPP.il2cpp_field_static_get_value(UnexceptionalStreamReader.NativeFieldInfoPtr_newlineChar, (void*)(&c));
				return c;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UnexceptionalStreamReader.NativeFieldInfoPtr_newlineChar, (void*)(&value));
			}
		}

		// Token: 0x04001FE5 RID: 8165
		private static readonly IntPtr NativeFieldInfoPtr_newline;

		// Token: 0x04001FE6 RID: 8166
		private static readonly IntPtr NativeFieldInfoPtr_newlineChar;

		// Token: 0x04001FE7 RID: 8167
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Stream_Encoding_0;

		// Token: 0x04001FE8 RID: 8168
		private static readonly IntPtr NativeMethodInfoPtr_Peek_Public_Virtual_Int32_0;

		// Token: 0x04001FE9 RID: 8169
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Virtual_Int32_0;

		// Token: 0x04001FEA RID: 8170
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Virtual_Int32_Il2CppStructArray_1_Char_Int32_Int32_0;

		// Token: 0x04001FEB RID: 8171
		private static readonly IntPtr NativeMethodInfoPtr_CheckEOL_Private_Boolean_Char_0;

		// Token: 0x04001FEC RID: 8172
		private static readonly IntPtr NativeMethodInfoPtr_ReadLine_Public_Virtual_String_0;

		// Token: 0x04001FED RID: 8173
		private static readonly IntPtr NativeMethodInfoPtr_ReadToEnd_Public_Virtual_String_0;
	}
}
