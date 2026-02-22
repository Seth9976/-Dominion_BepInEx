using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Text;

namespace Il2CppSystem.IO
{
	// Token: 0x02000223 RID: 547
	public class UnexceptionalStreamWriter : StreamWriter
	{
		// Token: 0x06002388 RID: 9096 RVA: 0x000C1D40 File Offset: 0x000BFF40
		// Note: this type is marked as 'beforefieldinit'.
		static UnexceptionalStreamWriter()
		{
			Il2CppClassPointerStore<UnexceptionalStreamWriter>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.IO", "UnexceptionalStreamWriter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnexceptionalStreamWriter>.NativeClassPtr);
			UnexceptionalStreamWriter.NativeMethodInfoPtr__ctor_Public_Void_Stream_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnexceptionalStreamWriter>.NativeClassPtr, 100669251);
			UnexceptionalStreamWriter.NativeMethodInfoPtr_Flush_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnexceptionalStreamWriter>.NativeClassPtr, 100669252);
			UnexceptionalStreamWriter.NativeMethodInfoPtr_Write_Public_Virtual_Void_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnexceptionalStreamWriter>.NativeClassPtr, 100669253);
			UnexceptionalStreamWriter.NativeMethodInfoPtr_Write_Public_Virtual_Void_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnexceptionalStreamWriter>.NativeClassPtr, 100669254);
			UnexceptionalStreamWriter.NativeMethodInfoPtr_Write_Public_Virtual_Void_Il2CppStructArray_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnexceptionalStreamWriter>.NativeClassPtr, 100669255);
			UnexceptionalStreamWriter.NativeMethodInfoPtr_Write_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnexceptionalStreamWriter>.NativeClassPtr, 100669256);
		}

		// Token: 0x06002389 RID: 9097 RVA: 0x000C1DE8 File Offset: 0x000BFFE8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 324455, RefRangeEnd = 324457, XrefRangeStart = 324451, XrefRangeEnd = 324455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnexceptionalStreamWriter(Stream stream, Encoding encoding)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnexceptionalStreamWriter>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stream);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(encoding);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnexceptionalStreamWriter.NativeMethodInfoPtr__ctor_Public_Void_Stream_Encoding_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600238A RID: 9098 RVA: 0x000C1E48 File Offset: 0x000C0048
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 324457, XrefRangeEnd = 324459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Flush()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnexceptionalStreamWriter.NativeMethodInfoPtr_Flush_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600238B RID: 9099 RVA: 0x000C1E84 File Offset: 0x000C0084
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 324459, XrefRangeEnd = 324461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Write(Il2CppStructArray<char> buffer, int index, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnexceptionalStreamWriter.NativeMethodInfoPtr_Write_Public_Virtual_Void_Il2CppStructArray_1_Char_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600238C RID: 9100 RVA: 0x000C1EF0 File Offset: 0x000C00F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 324461, XrefRangeEnd = 324463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Write(char value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnexceptionalStreamWriter.NativeMethodInfoPtr_Write_Public_Virtual_Void_Char_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600238D RID: 9101 RVA: 0x000C1F3C File Offset: 0x000C013C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 324463, XrefRangeEnd = 324465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Write(Il2CppStructArray<char> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnexceptionalStreamWriter.NativeMethodInfoPtr_Write_Public_Virtual_Void_Il2CppStructArray_1_Char_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600238E RID: 9102 RVA: 0x000C1F8C File Offset: 0x000C018C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 324465, XrefRangeEnd = 324467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Write(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnexceptionalStreamWriter.NativeMethodInfoPtr_Write_Public_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600238F RID: 9103 RVA: 0x0000BF91 File Offset: 0x0000A191
		public UnexceptionalStreamWriter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001FEE RID: 8174
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Stream_Encoding_0;

		// Token: 0x04001FEF RID: 8175
		private static readonly IntPtr NativeMethodInfoPtr_Flush_Public_Virtual_Void_0;

		// Token: 0x04001FF0 RID: 8176
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_Void_Il2CppStructArray_1_Char_Int32_Int32_0;

		// Token: 0x04001FF1 RID: 8177
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_Void_Char_0;

		// Token: 0x04001FF2 RID: 8178
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_Void_Il2CppStructArray_1_Char_0;

		// Token: 0x04001FF3 RID: 8179
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_Void_String_0;
	}
}
