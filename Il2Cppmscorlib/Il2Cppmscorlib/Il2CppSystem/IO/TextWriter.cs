using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.IO
{
	// Token: 0x0200020F RID: 527
	[Serializable]
	public class TextWriter : MarshalByRefObject
	{
		// Token: 0x0600222A RID: 8746 RVA: 0x000BBA50 File Offset: 0x000B9C50
		// Note: this type is marked as 'beforefieldinit'.
		static TextWriter()
		{
			Il2CppClassPointerStore<TextWriter>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.IO", "TextWriter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextWriter>.NativeClassPtr);
			TextWriter.NativeFieldInfoPtr_Null = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextWriter>.NativeClassPtr, "Null");
			TextWriter.NativeFieldInfoPtr__WriteCharDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextWriter>.NativeClassPtr, "_WriteCharDelegate");
			TextWriter.NativeFieldInfoPtr__WriteStringDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextWriter>.NativeClassPtr, "_WriteStringDelegate");
			TextWriter.NativeFieldInfoPtr__WriteCharArrayRangeDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextWriter>.NativeClassPtr, "_WriteCharArrayRangeDelegate");
			TextWriter.NativeFieldInfoPtr__WriteLineCharDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextWriter>.NativeClassPtr, "_WriteLineCharDelegate");
			TextWriter.NativeFieldInfoPtr__WriteLineStringDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextWriter>.NativeClassPtr, "_WriteLineStringDelegate");
			TextWriter.NativeFieldInfoPtr__WriteLineCharArrayRangeDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextWriter>.NativeClassPtr, "_WriteLineCharArrayRangeDelegate");
			TextWriter.NativeFieldInfoPtr__FlushDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextWriter>.NativeClassPtr, "_FlushDelegate");
			TextWriter.NativeFieldInfoPtr_CoreNewLine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextWriter>.NativeClassPtr, "CoreNewLine");
			TextWriter.NativeFieldInfoPtr_InternalFormatProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextWriter>.NativeClassPtr, "InternalFormatProvider");
			TextWriter.NativeMethodInfoPtr_get_InitialNewLine_Private_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextWriter>.NativeClassPtr, 100669004);
			TextWriter.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextWriter>.NativeClassPtr, 100669005);
			TextWriter.NativeMethodInfoPtr__ctor_Protected_Void_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextWriter>.NativeClassPtr, 100669006);
			TextWriter.NativeMethodInfoPtr_get_FormatProvider_Public_Virtual_New_get_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextWriter>.NativeClassPtr, 100669007);
			TextWriter.NativeMethodInfoPtr_Close_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextWriter>.NativeClassPtr, 100669008);
			TextWriter.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextWriter>.NativeClassPtr, 100669009);
			TextWriter.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextWriter>.NativeClassPtr, 100669010);
			TextWriter.NativeMethodInfoPtr_Flush_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextWriter>.NativeClassPtr, 100669011);
			TextWriter.NativeMethodInfoPtr_Synchronized_Public_Static_TextWriter_TextWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextWriter>.NativeClassPtr, 100669012);
			TextWriter.NativeMethodInfoPtr_Write_Public_Virtual_New_Void_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextWriter>.NativeClassPtr, 100669013);
			TextWriter.NativeMethodInfoPtr_Write_Public_Virtual_New_Void_Il2CppStructArray_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextWriter>.NativeClassPtr, 100669014);
			TextWriter.NativeMethodInfoPtr_Write_Public_Virtual_New_Void_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextWriter>.NativeClassPtr, 100669015);
			TextWriter.NativeMethodInfoPtr_Write_Public_Virtual_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextWriter>.NativeClassPtr, 100669016);
			TextWriter.NativeMethodInfoPtr_WriteLine_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextWriter>.NativeClassPtr, 100669017);
			TextWriter.NativeMethodInfoPtr_WriteLine_Public_Virtual_New_Void_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextWriter>.NativeClassPtr, 100669018);
			TextWriter.NativeMethodInfoPtr_WriteLine_Public_Virtual_New_Void_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextWriter>.NativeClassPtr, 100669019);
			TextWriter.NativeMethodInfoPtr_WriteLine_Public_Virtual_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextWriter>.NativeClassPtr, 100669020);
			TextWriter.NativeMethodInfoPtr_WriteLine_Public_Virtual_New_Void_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextWriter>.NativeClassPtr, 100669021);
			TextWriter.NativeMethodInfoPtr_WriteLine_Public_Virtual_New_Void_String_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextWriter>.NativeClassPtr, 100669022);
		}

		// Token: 0x17000731 RID: 1841
		// (get) Token: 0x0600222B RID: 8747 RVA: 0x000BBCC4 File Offset: 0x000B9EC4
		public unsafe static string InitialNewLine
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 322213, XrefRangeEnd = 322214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextWriter.NativeMethodInfoPtr_get_InitialNewLine_Private_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600222C RID: 8748 RVA: 0x000BBCF0 File Offset: 0x000B9EF0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 322220, RefRangeEnd = 322222, XrefRangeStart = 322214, XrefRangeEnd = 322220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TextWriter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextWriter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextWriter.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600222D RID: 8749 RVA: 0x000BBD2C File Offset: 0x000B9F2C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 322228, RefRangeEnd = 322233, XrefRangeStart = 322222, XrefRangeEnd = 322228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TextWriter(IFormatProvider formatProvider)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextWriter>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(formatProvider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextWriter.NativeMethodInfoPtr__ctor_Protected_Void_IFormatProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000732 RID: 1842
		// (get) Token: 0x0600222E RID: 8750 RVA: 0x000BBD78 File Offset: 0x000B9F78
		public unsafe virtual IFormatProvider FormatProvider
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 322233, XrefRangeEnd = 322243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextWriter.NativeMethodInfoPtr_get_FormatProvider_Public_Virtual_New_get_IFormatProvider_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IFormatProvider>(intPtr3) : null;
			}
		}

		// Token: 0x0600222F RID: 8751 RVA: 0x000BBDC4 File Offset: 0x000B9FC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 322243, XrefRangeEnd = 322247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextWriter.NativeMethodInfoPtr_Close_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002230 RID: 8752 RVA: 0x000BBE00 File Offset: 0x000BA000
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextWriter.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002231 RID: 8753 RVA: 0x000BBE4C File Offset: 0x000BA04C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 322247, XrefRangeEnd = 322251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextWriter.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002232 RID: 8754 RVA: 0x000BBE80 File Offset: 0x000BA080
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Flush()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextWriter.NativeMethodInfoPtr_Flush_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002233 RID: 8755 RVA: 0x000BBEBC File Offset: 0x000BA0BC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 322255, RefRangeEnd = 322258, XrefRangeStart = 322251, XrefRangeEnd = 322255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TextWriter Synchronized(TextWriter writer)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextWriter.NativeMethodInfoPtr_Synchronized_Public_Static_TextWriter_TextWriter_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TextWriter>(intPtr3) : null;
			}
		}

		// Token: 0x06002234 RID: 8756 RVA: 0x000BBF00 File Offset: 0x000BA100
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Write(char value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextWriter.NativeMethodInfoPtr_Write_Public_Virtual_New_Void_Char_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002235 RID: 8757 RVA: 0x000BBF4C File Offset: 0x000BA14C
		[CallerCount(0)]
		public unsafe virtual void Write(Il2CppStructArray<char> buffer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextWriter.NativeMethodInfoPtr_Write_Public_Virtual_New_Void_Il2CppStructArray_1_Char_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002236 RID: 8758 RVA: 0x000BBF9C File Offset: 0x000BA19C
		[CallerCount(0)]
		public unsafe virtual void Write(Il2CppStructArray<char> buffer, int index, int count)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextWriter.NativeMethodInfoPtr_Write_Public_Virtual_New_Void_Il2CppStructArray_1_Char_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002237 RID: 8759 RVA: 0x000BC008 File Offset: 0x000BA208
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 322258, XrefRangeEnd = 322259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Write(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextWriter.NativeMethodInfoPtr_Write_Public_Virtual_New_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002238 RID: 8760 RVA: 0x000BC058 File Offset: 0x000BA258
		[CallerCount(0)]
		public unsafe virtual void WriteLine()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextWriter.NativeMethodInfoPtr_WriteLine_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002239 RID: 8761 RVA: 0x000BC094 File Offset: 0x000BA294
		[CallerCount(0)]
		public unsafe virtual void WriteLine(char value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextWriter.NativeMethodInfoPtr_WriteLine_Public_Virtual_New_Void_Char_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600223A RID: 8762 RVA: 0x000BC0E0 File Offset: 0x000BA2E0
		[CallerCount(0)]
		public unsafe virtual void WriteLine(Il2CppStructArray<char> buffer, int index, int count)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextWriter.NativeMethodInfoPtr_WriteLine_Public_Virtual_New_Void_Il2CppStructArray_1_Char_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600223B RID: 8763 RVA: 0x000BC14C File Offset: 0x000BA34C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 322259, XrefRangeEnd = 322266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void WriteLine(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextWriter.NativeMethodInfoPtr_WriteLine_Public_Virtual_New_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600223C RID: 8764 RVA: 0x000BC19C File Offset: 0x000BA39C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 322266, XrefRangeEnd = 322267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void WriteLine(string format, Object arg0)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextWriter.NativeMethodInfoPtr_WriteLine_Public_Virtual_New_Void_String_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600223D RID: 8765 RVA: 0x000BC1FC File Offset: 0x000BA3FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 322267, XrefRangeEnd = 322268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void WriteLine(string format, Object arg0, Object arg1)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextWriter.NativeMethodInfoPtr_WriteLine_Public_Virtual_New_Void_String_Object_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600223E RID: 8766 RVA: 0x0000B96D File Offset: 0x00009B6D
		public TextWriter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000727 RID: 1831
		// (get) Token: 0x0600223F RID: 8767 RVA: 0x000BC270 File Offset: 0x000BA470
		// (set) Token: 0x06002240 RID: 8768 RVA: 0x0000B976 File Offset: 0x00009B76
		public unsafe static TextWriter Null
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TextWriter.NativeFieldInfoPtr_Null, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextWriter>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextWriter.NativeFieldInfoPtr_Null, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000728 RID: 1832
		// (get) Token: 0x06002241 RID: 8769 RVA: 0x000BC298 File Offset: 0x000BA498
		// (set) Token: 0x06002242 RID: 8770 RVA: 0x0000B988 File Offset: 0x00009B88
		public unsafe static Action<Object> _WriteCharDelegate
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TextWriter.NativeFieldInfoPtr__WriteCharDelegate, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Object>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextWriter.NativeFieldInfoPtr__WriteCharDelegate, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000729 RID: 1833
		// (get) Token: 0x06002243 RID: 8771 RVA: 0x000BC2C0 File Offset: 0x000BA4C0
		// (set) Token: 0x06002244 RID: 8772 RVA: 0x0000B99A File Offset: 0x00009B9A
		public unsafe static Action<Object> _WriteStringDelegate
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TextWriter.NativeFieldInfoPtr__WriteStringDelegate, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Object>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextWriter.NativeFieldInfoPtr__WriteStringDelegate, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700072A RID: 1834
		// (get) Token: 0x06002245 RID: 8773 RVA: 0x000BC2E8 File Offset: 0x000BA4E8
		// (set) Token: 0x06002246 RID: 8774 RVA: 0x0000B9AC File Offset: 0x00009BAC
		public unsafe static Action<Object> _WriteCharArrayRangeDelegate
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TextWriter.NativeFieldInfoPtr__WriteCharArrayRangeDelegate, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Object>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextWriter.NativeFieldInfoPtr__WriteCharArrayRangeDelegate, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700072B RID: 1835
		// (get) Token: 0x06002247 RID: 8775 RVA: 0x000BC310 File Offset: 0x000BA510
		// (set) Token: 0x06002248 RID: 8776 RVA: 0x0000B9BE File Offset: 0x00009BBE
		public unsafe static Action<Object> _WriteLineCharDelegate
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TextWriter.NativeFieldInfoPtr__WriteLineCharDelegate, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Object>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextWriter.NativeFieldInfoPtr__WriteLineCharDelegate, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700072C RID: 1836
		// (get) Token: 0x06002249 RID: 8777 RVA: 0x000BC338 File Offset: 0x000BA538
		// (set) Token: 0x0600224A RID: 8778 RVA: 0x0000B9D0 File Offset: 0x00009BD0
		public unsafe static Action<Object> _WriteLineStringDelegate
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TextWriter.NativeFieldInfoPtr__WriteLineStringDelegate, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Object>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextWriter.NativeFieldInfoPtr__WriteLineStringDelegate, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700072D RID: 1837
		// (get) Token: 0x0600224B RID: 8779 RVA: 0x000BC360 File Offset: 0x000BA560
		// (set) Token: 0x0600224C RID: 8780 RVA: 0x0000B9E2 File Offset: 0x00009BE2
		public unsafe static Action<Object> _WriteLineCharArrayRangeDelegate
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TextWriter.NativeFieldInfoPtr__WriteLineCharArrayRangeDelegate, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Object>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextWriter.NativeFieldInfoPtr__WriteLineCharArrayRangeDelegate, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700072E RID: 1838
		// (get) Token: 0x0600224D RID: 8781 RVA: 0x000BC388 File Offset: 0x000BA588
		// (set) Token: 0x0600224E RID: 8782 RVA: 0x0000B9F4 File Offset: 0x00009BF4
		public unsafe static Action<Object> _FlushDelegate
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TextWriter.NativeFieldInfoPtr__FlushDelegate, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Object>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextWriter.NativeFieldInfoPtr__FlushDelegate, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700072F RID: 1839
		// (get) Token: 0x0600224F RID: 8783 RVA: 0x000BC3B0 File Offset: 0x000BA5B0
		// (set) Token: 0x06002250 RID: 8784 RVA: 0x0000BA06 File Offset: 0x00009C06
		public unsafe Il2CppStructArray<char> CoreNewLine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextWriter.NativeFieldInfoPtr_CoreNewLine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextWriter.NativeFieldInfoPtr_CoreNewLine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000730 RID: 1840
		// (get) Token: 0x06002251 RID: 8785 RVA: 0x000BC3E0 File Offset: 0x000BA5E0
		// (set) Token: 0x06002252 RID: 8786 RVA: 0x0000BA25 File Offset: 0x00009C25
		public unsafe IFormatProvider InternalFormatProvider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextWriter.NativeFieldInfoPtr_InternalFormatProvider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IFormatProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextWriter.NativeFieldInfoPtr_InternalFormatProvider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001E87 RID: 7815
		private static readonly IntPtr NativeFieldInfoPtr_Null;

		// Token: 0x04001E88 RID: 7816
		private static readonly IntPtr NativeFieldInfoPtr__WriteCharDelegate;

		// Token: 0x04001E89 RID: 7817
		private static readonly IntPtr NativeFieldInfoPtr__WriteStringDelegate;

		// Token: 0x04001E8A RID: 7818
		private static readonly IntPtr NativeFieldInfoPtr__WriteCharArrayRangeDelegate;

		// Token: 0x04001E8B RID: 7819
		private static readonly IntPtr NativeFieldInfoPtr__WriteLineCharDelegate;

		// Token: 0x04001E8C RID: 7820
		private static readonly IntPtr NativeFieldInfoPtr__WriteLineStringDelegate;

		// Token: 0x04001E8D RID: 7821
		private static readonly IntPtr NativeFieldInfoPtr__WriteLineCharArrayRangeDelegate;

		// Token: 0x04001E8E RID: 7822
		private static readonly IntPtr NativeFieldInfoPtr__FlushDelegate;

		// Token: 0x04001E8F RID: 7823
		private static readonly IntPtr NativeFieldInfoPtr_CoreNewLine;

		// Token: 0x04001E90 RID: 7824
		private static readonly IntPtr NativeFieldInfoPtr_InternalFormatProvider;

		// Token: 0x04001E91 RID: 7825
		private static readonly IntPtr NativeMethodInfoPtr_get_InitialNewLine_Private_Static_get_String_0;

		// Token: 0x04001E92 RID: 7826
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04001E93 RID: 7827
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_IFormatProvider_0;

		// Token: 0x04001E94 RID: 7828
		private static readonly IntPtr NativeMethodInfoPtr_get_FormatProvider_Public_Virtual_New_get_IFormatProvider_0;

		// Token: 0x04001E95 RID: 7829
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Virtual_New_Void_0;

		// Token: 0x04001E96 RID: 7830
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0;

		// Token: 0x04001E97 RID: 7831
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x04001E98 RID: 7832
		private static readonly IntPtr NativeMethodInfoPtr_Flush_Public_Virtual_New_Void_0;

		// Token: 0x04001E99 RID: 7833
		private static readonly IntPtr NativeMethodInfoPtr_Synchronized_Public_Static_TextWriter_TextWriter_0;

		// Token: 0x04001E9A RID: 7834
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_New_Void_Char_0;

		// Token: 0x04001E9B RID: 7835
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_New_Void_Il2CppStructArray_1_Char_0;

		// Token: 0x04001E9C RID: 7836
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_New_Void_Il2CppStructArray_1_Char_Int32_Int32_0;

		// Token: 0x04001E9D RID: 7837
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_New_Void_String_0;

		// Token: 0x04001E9E RID: 7838
		private static readonly IntPtr NativeMethodInfoPtr_WriteLine_Public_Virtual_New_Void_0;

		// Token: 0x04001E9F RID: 7839
		private static readonly IntPtr NativeMethodInfoPtr_WriteLine_Public_Virtual_New_Void_Char_0;

		// Token: 0x04001EA0 RID: 7840
		private static readonly IntPtr NativeMethodInfoPtr_WriteLine_Public_Virtual_New_Void_Il2CppStructArray_1_Char_Int32_Int32_0;

		// Token: 0x04001EA1 RID: 7841
		private static readonly IntPtr NativeMethodInfoPtr_WriteLine_Public_Virtual_New_Void_String_0;

		// Token: 0x04001EA2 RID: 7842
		private static readonly IntPtr NativeMethodInfoPtr_WriteLine_Public_Virtual_New_Void_String_Object_0;

		// Token: 0x04001EA3 RID: 7843
		private static readonly IntPtr NativeMethodInfoPtr_WriteLine_Public_Virtual_New_Void_String_Object_Object_0;

		// Token: 0x020005D7 RID: 1495
		[Serializable]
		public sealed class NullTextWriter : TextWriter
		{
			// Token: 0x060051D1 RID: 20945 RVA: 0x0016D780 File Offset: 0x0016B980
			// Note: this type is marked as 'beforefieldinit'.
			static NullTextWriter()
			{
				Il2CppClassPointerStore<TextWriter.NullTextWriter>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TextWriter>.NativeClassPtr, "NullTextWriter");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextWriter.NullTextWriter>.NativeClassPtr);
				TextWriter.NullTextWriter.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextWriter.NullTextWriter>.NativeClassPtr, 100669024);
				TextWriter.NullTextWriter.NativeMethodInfoPtr_Write_Public_Virtual_Void_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextWriter.NullTextWriter>.NativeClassPtr, 100669025);
				TextWriter.NullTextWriter.NativeMethodInfoPtr_Write_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextWriter.NullTextWriter>.NativeClassPtr, 100669026);
				TextWriter.NullTextWriter.NativeMethodInfoPtr_WriteLine_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextWriter.NullTextWriter>.NativeClassPtr, 100669027);
				TextWriter.NullTextWriter.NativeMethodInfoPtr_WriteLine_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextWriter.NullTextWriter>.NativeClassPtr, 100669028);
			}

			// Token: 0x060051D2 RID: 20946 RVA: 0x0016D810 File Offset: 0x0016BA10
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 322150, XrefRangeEnd = 322158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe NullTextWriter()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextWriter.NullTextWriter>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextWriter.NullTextWriter.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060051D3 RID: 20947 RVA: 0x0016D84C File Offset: 0x0016BA4C
			[CallerCount(3728)]
			[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextWriter.NullTextWriter.NativeMethodInfoPtr_Write_Public_Virtual_Void_Il2CppStructArray_1_Char_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060051D4 RID: 20948 RVA: 0x0016D8AC File Offset: 0x0016BAAC
			[CallerCount(3728)]
			[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Write(string value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextWriter.NullTextWriter.NativeMethodInfoPtr_Write_Public_Virtual_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060051D5 RID: 20949 RVA: 0x0016D8F0 File Offset: 0x0016BAF0
			[CallerCount(3728)]
			[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void WriteLine()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextWriter.NullTextWriter.NativeMethodInfoPtr_WriteLine_Public_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060051D6 RID: 20950 RVA: 0x0016D924 File Offset: 0x0016BB24
			[CallerCount(3728)]
			[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void WriteLine(string value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextWriter.NullTextWriter.NativeMethodInfoPtr_WriteLine_Public_Virtual_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060051D7 RID: 20951 RVA: 0x0001F31F File Offset: 0x0001D51F
			public NullTextWriter(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04004237 RID: 16951
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

			// Token: 0x04004238 RID: 16952
			private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_Void_Il2CppStructArray_1_Char_Int32_Int32_0;

			// Token: 0x04004239 RID: 16953
			private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_Void_String_0;

			// Token: 0x0400423A RID: 16954
			private static readonly IntPtr NativeMethodInfoPtr_WriteLine_Public_Virtual_Void_0;

			// Token: 0x0400423B RID: 16955
			private static readonly IntPtr NativeMethodInfoPtr_WriteLine_Public_Virtual_Void_String_0;
		}

		// Token: 0x020005D8 RID: 1496
		[Serializable]
		public sealed class SyncTextWriter : TextWriter
		{
			// Token: 0x060051D8 RID: 20952 RVA: 0x0016D968 File Offset: 0x0016BB68
			// Note: this type is marked as 'beforefieldinit'.
			static SyncTextWriter()
			{
				Il2CppClassPointerStore<TextWriter.SyncTextWriter>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TextWriter>.NativeClassPtr, "SyncTextWriter");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextWriter.SyncTextWriter>.NativeClassPtr);
				TextWriter.SyncTextWriter.NativeFieldInfoPtr__out = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextWriter.SyncTextWriter>.NativeClassPtr, "_out");
				TextWriter.SyncTextWriter.NativeMethodInfoPtr__ctor_Internal_Void_TextWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextWriter.SyncTextWriter>.NativeClassPtr, 100669029);
				TextWriter.SyncTextWriter.NativeMethodInfoPtr_get_FormatProvider_Public_Virtual_get_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextWriter.SyncTextWriter>.NativeClassPtr, 100669030);
				TextWriter.SyncTextWriter.NativeMethodInfoPtr_Close_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextWriter.SyncTextWriter>.NativeClassPtr, 100669031);
				TextWriter.SyncTextWriter.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextWriter.SyncTextWriter>.NativeClassPtr, 100669032);
				TextWriter.SyncTextWriter.NativeMethodInfoPtr_Flush_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextWriter.SyncTextWriter>.NativeClassPtr, 100669033);
				TextWriter.SyncTextWriter.NativeMethodInfoPtr_Write_Public_Virtual_Void_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextWriter.SyncTextWriter>.NativeClassPtr, 100669034);
				TextWriter.SyncTextWriter.NativeMethodInfoPtr_Write_Public_Virtual_Void_Il2CppStructArray_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextWriter.SyncTextWriter>.NativeClassPtr, 100669035);
				TextWriter.SyncTextWriter.NativeMethodInfoPtr_Write_Public_Virtual_Void_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextWriter.SyncTextWriter>.NativeClassPtr, 100669036);
				TextWriter.SyncTextWriter.NativeMethodInfoPtr_Write_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextWriter.SyncTextWriter>.NativeClassPtr, 100669037);
				TextWriter.SyncTextWriter.NativeMethodInfoPtr_WriteLine_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextWriter.SyncTextWriter>.NativeClassPtr, 100669038);
				TextWriter.SyncTextWriter.NativeMethodInfoPtr_WriteLine_Public_Virtual_Void_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextWriter.SyncTextWriter>.NativeClassPtr, 100669039);
				TextWriter.SyncTextWriter.NativeMethodInfoPtr_WriteLine_Public_Virtual_Void_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextWriter.SyncTextWriter>.NativeClassPtr, 100669040);
				TextWriter.SyncTextWriter.NativeMethodInfoPtr_WriteLine_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextWriter.SyncTextWriter>.NativeClassPtr, 100669041);
				TextWriter.SyncTextWriter.NativeMethodInfoPtr_WriteLine_Public_Virtual_Void_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextWriter.SyncTextWriter>.NativeClassPtr, 100669042);
				TextWriter.SyncTextWriter.NativeMethodInfoPtr_WriteLine_Public_Virtual_Void_String_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextWriter.SyncTextWriter>.NativeClassPtr, 100669043);
			}

			// Token: 0x060051D9 RID: 20953 RVA: 0x0016DAD4 File Offset: 0x0016BCD4
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 322162, RefRangeEnd = 322163, XrefRangeStart = 322158, XrefRangeEnd = 322162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SyncTextWriter(TextWriter t)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextWriter.SyncTextWriter>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextWriter.SyncTextWriter.NativeMethodInfoPtr__ctor_Internal_Void_TextWriter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x170014EC RID: 5356
			// (get) Token: 0x060051DA RID: 20954 RVA: 0x0016DB20 File Offset: 0x0016BD20
			public unsafe override IFormatProvider FormatProvider
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextWriter.SyncTextWriter.NativeMethodInfoPtr_get_FormatProvider_Public_Virtual_get_IFormatProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IFormatProvider>(intPtr3) : null;
				}
			}

			// Token: 0x060051DB RID: 20955 RVA: 0x0016DB60 File Offset: 0x0016BD60
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Close()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextWriter.SyncTextWriter.NativeMethodInfoPtr_Close_Public_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060051DC RID: 20956 RVA: 0x0016DB94 File Offset: 0x0016BD94
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 322163, XrefRangeEnd = 322166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Dispose(bool disposing)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref disposing;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextWriter.SyncTextWriter.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060051DD RID: 20957 RVA: 0x0016DBD4 File Offset: 0x0016BDD4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Flush()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextWriter.SyncTextWriter.NativeMethodInfoPtr_Flush_Public_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060051DE RID: 20958 RVA: 0x0016DC08 File Offset: 0x0016BE08
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 322166, XrefRangeEnd = 322167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Write(char value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextWriter.SyncTextWriter.NativeMethodInfoPtr_Write_Public_Virtual_Void_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060051DF RID: 20959 RVA: 0x0016DC48 File Offset: 0x0016BE48
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Write(Il2CppStructArray<char> buffer)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextWriter.SyncTextWriter.NativeMethodInfoPtr_Write_Public_Virtual_Void_Il2CppStructArray_1_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060051E0 RID: 20960 RVA: 0x0016DC8C File Offset: 0x0016BE8C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 322167, XrefRangeEnd = 322168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextWriter.SyncTextWriter.NativeMethodInfoPtr_Write_Public_Virtual_Void_Il2CppStructArray_1_Char_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060051E1 RID: 20961 RVA: 0x0016DCEC File Offset: 0x0016BEEC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Write(string value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextWriter.SyncTextWriter.NativeMethodInfoPtr_Write_Public_Virtual_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060051E2 RID: 20962 RVA: 0x0016DD30 File Offset: 0x0016BF30
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void WriteLine()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextWriter.SyncTextWriter.NativeMethodInfoPtr_WriteLine_Public_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060051E3 RID: 20963 RVA: 0x0016DD64 File Offset: 0x0016BF64
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 322168, XrefRangeEnd = 322169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void WriteLine(char value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextWriter.SyncTextWriter.NativeMethodInfoPtr_WriteLine_Public_Virtual_Void_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060051E4 RID: 20964 RVA: 0x0016DDA4 File Offset: 0x0016BFA4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 322169, XrefRangeEnd = 322170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void WriteLine(Il2CppStructArray<char> buffer, int index, int count)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextWriter.SyncTextWriter.NativeMethodInfoPtr_WriteLine_Public_Virtual_Void_Il2CppStructArray_1_Char_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060051E5 RID: 20965 RVA: 0x0016DE04 File Offset: 0x0016C004
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 322170, XrefRangeEnd = 322171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void WriteLine(string value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextWriter.SyncTextWriter.NativeMethodInfoPtr_WriteLine_Public_Virtual_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060051E6 RID: 20966 RVA: 0x0016DE48 File Offset: 0x0016C048
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 322171, XrefRangeEnd = 322172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void WriteLine(string format, Object arg0)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextWriter.SyncTextWriter.NativeMethodInfoPtr_WriteLine_Public_Virtual_Void_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060051E7 RID: 20967 RVA: 0x0016DE9C File Offset: 0x0016C09C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 322172, XrefRangeEnd = 322173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void WriteLine(string format, Object arg0, Object arg1)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextWriter.SyncTextWriter.NativeMethodInfoPtr_WriteLine_Public_Virtual_Void_String_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060051E8 RID: 20968 RVA: 0x0001F328 File Offset: 0x0001D528
			public SyncTextWriter(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170014EB RID: 5355
			// (get) Token: 0x060051E9 RID: 20969 RVA: 0x0016DF04 File Offset: 0x0016C104
			// (set) Token: 0x060051EA RID: 20970 RVA: 0x0001F331 File Offset: 0x0001D531
			public unsafe TextWriter _out
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextWriter.SyncTextWriter.NativeFieldInfoPtr__out);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextWriter>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextWriter.SyncTextWriter.NativeFieldInfoPtr__out), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400423C RID: 16956
			private static readonly IntPtr NativeFieldInfoPtr__out;

			// Token: 0x0400423D RID: 16957
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_TextWriter_0;

			// Token: 0x0400423E RID: 16958
			private static readonly IntPtr NativeMethodInfoPtr_get_FormatProvider_Public_Virtual_get_IFormatProvider_0;

			// Token: 0x0400423F RID: 16959
			private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Virtual_Void_0;

			// Token: 0x04004240 RID: 16960
			private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0;

			// Token: 0x04004241 RID: 16961
			private static readonly IntPtr NativeMethodInfoPtr_Flush_Public_Virtual_Void_0;

			// Token: 0x04004242 RID: 16962
			private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_Void_Char_0;

			// Token: 0x04004243 RID: 16963
			private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_Void_Il2CppStructArray_1_Char_0;

			// Token: 0x04004244 RID: 16964
			private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_Void_Il2CppStructArray_1_Char_Int32_Int32_0;

			// Token: 0x04004245 RID: 16965
			private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_Void_String_0;

			// Token: 0x04004246 RID: 16966
			private static readonly IntPtr NativeMethodInfoPtr_WriteLine_Public_Virtual_Void_0;

			// Token: 0x04004247 RID: 16967
			private static readonly IntPtr NativeMethodInfoPtr_WriteLine_Public_Virtual_Void_Char_0;

			// Token: 0x04004248 RID: 16968
			private static readonly IntPtr NativeMethodInfoPtr_WriteLine_Public_Virtual_Void_Il2CppStructArray_1_Char_Int32_Int32_0;

			// Token: 0x04004249 RID: 16969
			private static readonly IntPtr NativeMethodInfoPtr_WriteLine_Public_Virtual_Void_String_0;

			// Token: 0x0400424A RID: 16970
			private static readonly IntPtr NativeMethodInfoPtr_WriteLine_Public_Virtual_Void_String_Object_0;

			// Token: 0x0400424B RID: 16971
			private static readonly IntPtr NativeMethodInfoPtr_WriteLine_Public_Virtual_Void_String_Object_Object_0;
		}

		// Token: 0x020005D9 RID: 1497
		[ObfuscatedName("System.IO.TextWriter+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x060051EB RID: 20971 RVA: 0x0016DF34 File Offset: 0x0016C134
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<TextWriter.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TextWriter>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextWriter.__c>.NativeClassPtr);
				TextWriter.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextWriter.__c>.NativeClassPtr, "<>9");
				TextWriter.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextWriter.__c>.NativeClassPtr, 100669045);
				TextWriter.__c.NativeMethodInfoPtr___cctor_b__73_0_Internal_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextWriter.__c>.NativeClassPtr, 100669046);
				TextWriter.__c.NativeMethodInfoPtr___cctor_b__73_1_Internal_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextWriter.__c>.NativeClassPtr, 100669047);
				TextWriter.__c.NativeMethodInfoPtr___cctor_b__73_2_Internal_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextWriter.__c>.NativeClassPtr, 100669048);
				TextWriter.__c.NativeMethodInfoPtr___cctor_b__73_3_Internal_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextWriter.__c>.NativeClassPtr, 100669049);
				TextWriter.__c.NativeMethodInfoPtr___cctor_b__73_4_Internal_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextWriter.__c>.NativeClassPtr, 100669050);
				TextWriter.__c.NativeMethodInfoPtr___cctor_b__73_5_Internal_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextWriter.__c>.NativeClassPtr, 100669051);
				TextWriter.__c.NativeMethodInfoPtr___cctor_b__73_6_Internal_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextWriter.__c>.NativeClassPtr, 100669052);
			}

			// Token: 0x060051EC RID: 20972 RVA: 0x0016E014 File Offset: 0x0016C214
			[CallerCount(817)]
			[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextWriter.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextWriter.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060051ED RID: 20973 RVA: 0x0016E050 File Offset: 0x0016C250
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 322173, XrefRangeEnd = 322179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __cctor_b__73_0(Object state)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(state);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextWriter.__c.NativeMethodInfoPtr___cctor_b__73_0_Internal_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060051EE RID: 20974 RVA: 0x0016E094 File Offset: 0x0016C294
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 322179, XrefRangeEnd = 322185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __cctor_b__73_1(Object state)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(state);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextWriter.__c.NativeMethodInfoPtr___cctor_b__73_1_Internal_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060051EF RID: 20975 RVA: 0x0016E0D8 File Offset: 0x0016C2D8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 322185, XrefRangeEnd = 322191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __cctor_b__73_2(Object state)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(state);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextWriter.__c.NativeMethodInfoPtr___cctor_b__73_2_Internal_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060051F0 RID: 20976 RVA: 0x0016E11C File Offset: 0x0016C31C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 322191, XrefRangeEnd = 322197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __cctor_b__73_3(Object state)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(state);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextWriter.__c.NativeMethodInfoPtr___cctor_b__73_3_Internal_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060051F1 RID: 20977 RVA: 0x0016E160 File Offset: 0x0016C360
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 322197, XrefRangeEnd = 322203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __cctor_b__73_4(Object state)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(state);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextWriter.__c.NativeMethodInfoPtr___cctor_b__73_4_Internal_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060051F2 RID: 20978 RVA: 0x0016E1A4 File Offset: 0x0016C3A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 322203, XrefRangeEnd = 322209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __cctor_b__73_5(Object state)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(state);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextWriter.__c.NativeMethodInfoPtr___cctor_b__73_5_Internal_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060051F3 RID: 20979 RVA: 0x0016E1E8 File Offset: 0x0016C3E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 322209, XrefRangeEnd = 322213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __cctor_b__73_6(Object state)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(state);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextWriter.__c.NativeMethodInfoPtr___cctor_b__73_6_Internal_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060051F4 RID: 20980 RVA: 0x0001F350 File Offset: 0x0001D550
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170014ED RID: 5357
			// (get) Token: 0x060051F5 RID: 20981 RVA: 0x0016E22C File Offset: 0x0016C42C
			// (set) Token: 0x060051F6 RID: 20982 RVA: 0x0001F359 File Offset: 0x0001D559
			public unsafe static TextWriter.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TextWriter.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextWriter.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TextWriter.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400424C RID: 16972
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400424D RID: 16973
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400424E RID: 16974
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__73_0_Internal_Void_Object_0;

			// Token: 0x0400424F RID: 16975
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__73_1_Internal_Void_Object_0;

			// Token: 0x04004250 RID: 16976
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__73_2_Internal_Void_Object_0;

			// Token: 0x04004251 RID: 16977
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__73_3_Internal_Void_Object_0;

			// Token: 0x04004252 RID: 16978
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__73_4_Internal_Void_Object_0;

			// Token: 0x04004253 RID: 16979
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__73_5_Internal_Void_Object_0;

			// Token: 0x04004254 RID: 16980
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__73_6_Internal_Void_Object_0;
		}
	}
}
