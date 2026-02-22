using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.IO
{
	// Token: 0x0200020E RID: 526
	[Serializable]
	public class TextReader : MarshalByRefObject
	{
		// Token: 0x06002218 RID: 8728 RVA: 0x000BB5C8 File Offset: 0x000B97C8
		// Note: this type is marked as 'beforefieldinit'.
		static TextReader()
		{
			Il2CppClassPointerStore<TextReader>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.IO", "TextReader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextReader>.NativeClassPtr);
			TextReader.NativeFieldInfoPtr__ReadLineDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextReader>.NativeClassPtr, "_ReadLineDelegate");
			TextReader.NativeFieldInfoPtr__ReadDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextReader>.NativeClassPtr, "_ReadDelegate");
			TextReader.NativeFieldInfoPtr_Null = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextReader>.NativeClassPtr, "Null");
			TextReader.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextReader>.NativeClassPtr, 100668978);
			TextReader.NativeMethodInfoPtr_Close_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextReader>.NativeClassPtr, 100668979);
			TextReader.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextReader>.NativeClassPtr, 100668980);
			TextReader.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextReader>.NativeClassPtr, 100668981);
			TextReader.NativeMethodInfoPtr_Peek_Public_Virtual_New_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextReader>.NativeClassPtr, 100668982);
			TextReader.NativeMethodInfoPtr_Read_Public_Virtual_New_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextReader>.NativeClassPtr, 100668983);
			TextReader.NativeMethodInfoPtr_Read_Public_Virtual_New_Int32_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextReader>.NativeClassPtr, 100668984);
			TextReader.NativeMethodInfoPtr_ReadToEnd_Public_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextReader>.NativeClassPtr, 100668985);
			TextReader.NativeMethodInfoPtr_ReadLine_Public_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextReader>.NativeClassPtr, 100668986);
			TextReader.NativeMethodInfoPtr_Synchronized_Public_Static_TextReader_TextReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextReader>.NativeClassPtr, 100668987);
		}

		// Token: 0x06002219 RID: 8729 RVA: 0x000BB6FC File Offset: 0x000B98FC
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 12105, RefRangeEnd = 12219, XrefRangeStart = 12105, XrefRangeEnd = 12219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TextReader()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextReader>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextReader.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600221A RID: 8730 RVA: 0x000BB738 File Offset: 0x000B9938
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 322117, XrefRangeEnd = 322121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextReader.NativeMethodInfoPtr_Close_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600221B RID: 8731 RVA: 0x000BB774 File Offset: 0x000B9974
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 322125, RefRangeEnd = 322129, XrefRangeStart = 322121, XrefRangeEnd = 322125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextReader.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600221C RID: 8732 RVA: 0x000BB7A8 File Offset: 0x000B99A8
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextReader.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600221D RID: 8733 RVA: 0x000BB7F4 File Offset: 0x000B99F4
		[CallerCount(0)]
		public unsafe virtual int Peek()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextReader.NativeMethodInfoPtr_Peek_Public_Virtual_New_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600221E RID: 8734 RVA: 0x000BB83C File Offset: 0x000B9A3C
		[CallerCount(0)]
		public unsafe virtual int Read()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextReader.NativeMethodInfoPtr_Read_Public_Virtual_New_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600221F RID: 8735 RVA: 0x000BB884 File Offset: 0x000B9A84
		[CallerCount(0)]
		public unsafe virtual int Read([In] [Out] Il2CppStructArray<char> buffer, int index, int count)
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextReader.NativeMethodInfoPtr_Read_Public_Virtual_New_Int32_Il2CppStructArray_1_Char_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			*buffer = ((intPtr4 == 0) ? null : new Il2CppStructArray<char>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06002220 RID: 8736 RVA: 0x000BB90C File Offset: 0x000B9B0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 322129, XrefRangeEnd = 322139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string ReadToEnd()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextReader.NativeMethodInfoPtr_ReadToEnd_Public_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002221 RID: 8737 RVA: 0x000BB950 File Offset: 0x000B9B50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 322139, XrefRangeEnd = 322145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string ReadLine()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextReader.NativeMethodInfoPtr_ReadLine_Public_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002222 RID: 8738 RVA: 0x000BB994 File Offset: 0x000B9B94
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 322149, RefRangeEnd = 322150, XrefRangeStart = 322145, XrefRangeEnd = 322149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TextReader Synchronized(TextReader reader)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextReader.NativeMethodInfoPtr_Synchronized_Public_Static_TextReader_TextReader_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TextReader>(intPtr3) : null;
			}
		}

		// Token: 0x06002223 RID: 8739 RVA: 0x0000B92E File Offset: 0x00009B2E
		public TextReader(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000724 RID: 1828
		// (get) Token: 0x06002224 RID: 8740 RVA: 0x000BB9D8 File Offset: 0x000B9BD8
		// (set) Token: 0x06002225 RID: 8741 RVA: 0x0000B937 File Offset: 0x00009B37
		public unsafe static Func<Object, string> _ReadLineDelegate
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TextReader.NativeFieldInfoPtr__ReadLineDelegate, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Object, string>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextReader.NativeFieldInfoPtr__ReadLineDelegate, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000725 RID: 1829
		// (get) Token: 0x06002226 RID: 8742 RVA: 0x000BBA00 File Offset: 0x000B9C00
		// (set) Token: 0x06002227 RID: 8743 RVA: 0x0000B949 File Offset: 0x00009B49
		public unsafe static Func<Object, int> _ReadDelegate
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TextReader.NativeFieldInfoPtr__ReadDelegate, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Object, int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextReader.NativeFieldInfoPtr__ReadDelegate, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000726 RID: 1830
		// (get) Token: 0x06002228 RID: 8744 RVA: 0x000BBA28 File Offset: 0x000B9C28
		// (set) Token: 0x06002229 RID: 8745 RVA: 0x0000B95B File Offset: 0x00009B5B
		public unsafe static TextReader Null
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TextReader.NativeFieldInfoPtr_Null, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextReader>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextReader.NativeFieldInfoPtr_Null, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001E7A RID: 7802
		private static readonly IntPtr NativeFieldInfoPtr__ReadLineDelegate;

		// Token: 0x04001E7B RID: 7803
		private static readonly IntPtr NativeFieldInfoPtr__ReadDelegate;

		// Token: 0x04001E7C RID: 7804
		private static readonly IntPtr NativeFieldInfoPtr_Null;

		// Token: 0x04001E7D RID: 7805
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04001E7E RID: 7806
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Virtual_New_Void_0;

		// Token: 0x04001E7F RID: 7807
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x04001E80 RID: 7808
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0;

		// Token: 0x04001E81 RID: 7809
		private static readonly IntPtr NativeMethodInfoPtr_Peek_Public_Virtual_New_Int32_0;

		// Token: 0x04001E82 RID: 7810
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Virtual_New_Int32_0;

		// Token: 0x04001E83 RID: 7811
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Virtual_New_Int32_Il2CppStructArray_1_Char_Int32_Int32_0;

		// Token: 0x04001E84 RID: 7812
		private static readonly IntPtr NativeMethodInfoPtr_ReadToEnd_Public_Virtual_New_String_0;

		// Token: 0x04001E85 RID: 7813
		private static readonly IntPtr NativeMethodInfoPtr_ReadLine_Public_Virtual_New_String_0;

		// Token: 0x04001E86 RID: 7814
		private static readonly IntPtr NativeMethodInfoPtr_Synchronized_Public_Static_TextReader_TextReader_0;

		// Token: 0x020005D4 RID: 1492
		[Serializable]
		public sealed class NullTextReader : TextReader
		{
			// Token: 0x060051B9 RID: 20921 RVA: 0x0016D18C File Offset: 0x0016B38C
			// Note: this type is marked as 'beforefieldinit'.
			static NullTextReader()
			{
				Il2CppClassPointerStore<TextReader.NullTextReader>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TextReader>.NativeClassPtr, "NullTextReader");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextReader.NullTextReader>.NativeClassPtr);
				TextReader.NullTextReader.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextReader.NullTextReader>.NativeClassPtr, 100668989);
				TextReader.NullTextReader.NativeMethodInfoPtr_Read_Public_Virtual_Int32_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextReader.NullTextReader>.NativeClassPtr, 100668990);
				TextReader.NullTextReader.NativeMethodInfoPtr_ReadLine_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextReader.NullTextReader>.NativeClassPtr, 100668991);
			}

			// Token: 0x060051BA RID: 20922 RVA: 0x0016D1F4 File Offset: 0x0016B3F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 322090, XrefRangeEnd = 322094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe NullTextReader()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextReader.NullTextReader>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextReader.NullTextReader.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060051BB RID: 20923 RVA: 0x0016D230 File Offset: 0x0016B430
			[CallerCount(23)]
			[CachedScanResults(RefRangeStart = 11853, RefRangeEnd = 11876, XrefRangeStart = 11853, XrefRangeEnd = 11876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Read(Il2CppStructArray<char> buffer, int index, int count)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextReader.NullTextReader.NativeMethodInfoPtr_Read_Public_Virtual_Int32_Il2CppStructArray_1_Char_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060051BC RID: 20924 RVA: 0x0016D29C File Offset: 0x0016B49C
			[CallerCount(23)]
			[CachedScanResults(RefRangeStart = 11853, RefRangeEnd = 11876, XrefRangeStart = 11853, XrefRangeEnd = 11876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override string ReadLine()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextReader.NullTextReader.NativeMethodInfoPtr_ReadLine_Public_Virtual_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x060051BD RID: 20925 RVA: 0x0001F2D3 File Offset: 0x0001D4D3
			public NullTextReader(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04004227 RID: 16935
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04004228 RID: 16936
			private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Virtual_Int32_Il2CppStructArray_1_Char_Int32_Int32_0;

			// Token: 0x04004229 RID: 16937
			private static readonly IntPtr NativeMethodInfoPtr_ReadLine_Public_Virtual_String_0;
		}

		// Token: 0x020005D5 RID: 1493
		[Serializable]
		public sealed class SyncTextReader : TextReader
		{
			// Token: 0x060051BE RID: 20926 RVA: 0x0016D2D4 File Offset: 0x0016B4D4
			// Note: this type is marked as 'beforefieldinit'.
			static SyncTextReader()
			{
				Il2CppClassPointerStore<TextReader.SyncTextReader>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TextReader>.NativeClassPtr, "SyncTextReader");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextReader.SyncTextReader>.NativeClassPtr);
				TextReader.SyncTextReader.NativeFieldInfoPtr__in = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextReader.SyncTextReader>.NativeClassPtr, "_in");
				TextReader.SyncTextReader.NativeMethodInfoPtr__ctor_Internal_Void_TextReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextReader.SyncTextReader>.NativeClassPtr, 100668992);
				TextReader.SyncTextReader.NativeMethodInfoPtr_Close_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextReader.SyncTextReader>.NativeClassPtr, 100668993);
				TextReader.SyncTextReader.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextReader.SyncTextReader>.NativeClassPtr, 100668994);
				TextReader.SyncTextReader.NativeMethodInfoPtr_Peek_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextReader.SyncTextReader>.NativeClassPtr, 100668995);
				TextReader.SyncTextReader.NativeMethodInfoPtr_Read_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextReader.SyncTextReader>.NativeClassPtr, 100668996);
				TextReader.SyncTextReader.NativeMethodInfoPtr_Read_Public_Virtual_Int32_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextReader.SyncTextReader>.NativeClassPtr, 100668997);
				TextReader.SyncTextReader.NativeMethodInfoPtr_ReadLine_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextReader.SyncTextReader>.NativeClassPtr, 100668998);
				TextReader.SyncTextReader.NativeMethodInfoPtr_ReadToEnd_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextReader.SyncTextReader>.NativeClassPtr, 100668999);
			}

			// Token: 0x060051BF RID: 20927 RVA: 0x0016D3B4 File Offset: 0x0016B5B4
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 322098, RefRangeEnd = 322099, XrefRangeStart = 322094, XrefRangeEnd = 322098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SyncTextReader(TextReader t)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextReader.SyncTextReader>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextReader.SyncTextReader.NativeMethodInfoPtr__ctor_Internal_Void_TextReader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060051C0 RID: 20928 RVA: 0x0016D400 File Offset: 0x0016B600
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 322099, XrefRangeEnd = 322100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Close()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextReader.SyncTextReader.NativeMethodInfoPtr_Close_Public_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060051C1 RID: 20929 RVA: 0x0016D434 File Offset: 0x0016B634
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 322100, XrefRangeEnd = 322103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Dispose(bool disposing)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref disposing;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextReader.SyncTextReader.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060051C2 RID: 20930 RVA: 0x0016D474 File Offset: 0x0016B674
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Peek()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextReader.SyncTextReader.NativeMethodInfoPtr_Peek_Public_Virtual_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060051C3 RID: 20931 RVA: 0x0016D4B0 File Offset: 0x0016B6B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 322103, XrefRangeEnd = 322104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Read()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextReader.SyncTextReader.NativeMethodInfoPtr_Read_Public_Virtual_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060051C4 RID: 20932 RVA: 0x0016D4EC File Offset: 0x0016B6EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 322104, XrefRangeEnd = 322105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Read([In] [Out] Il2CppStructArray<char> buffer, int index, int count)
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
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(TextReader.SyncTextReader.NativeMethodInfoPtr_Read_Public_Virtual_Int32_Il2CppStructArray_1_Char_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				*buffer = ((intPtr4 == 0) ? null : new Il2CppStructArray<char>(intPtr4));
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}

			// Token: 0x060051C5 RID: 20933 RVA: 0x0016D568 File Offset: 0x0016B768
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 322105, XrefRangeEnd = 322106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override string ReadLine()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextReader.SyncTextReader.NativeMethodInfoPtr_ReadLine_Public_Virtual_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x060051C6 RID: 20934 RVA: 0x0016D5A0 File Offset: 0x0016B7A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 322106, XrefRangeEnd = 322107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override string ReadToEnd()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextReader.SyncTextReader.NativeMethodInfoPtr_ReadToEnd_Public_Virtual_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x060051C7 RID: 20935 RVA: 0x0001F2DC File Offset: 0x0001D4DC
			public SyncTextReader(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170014E9 RID: 5353
			// (get) Token: 0x060051C8 RID: 20936 RVA: 0x0016D5D8 File Offset: 0x0016B7D8
			// (set) Token: 0x060051C9 RID: 20937 RVA: 0x0001F2E5 File Offset: 0x0001D4E5
			public unsafe TextReader _in
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextReader.SyncTextReader.NativeFieldInfoPtr__in);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextReader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextReader.SyncTextReader.NativeFieldInfoPtr__in), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400422A RID: 16938
			private static readonly IntPtr NativeFieldInfoPtr__in;

			// Token: 0x0400422B RID: 16939
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_TextReader_0;

			// Token: 0x0400422C RID: 16940
			private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Virtual_Void_0;

			// Token: 0x0400422D RID: 16941
			private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0;

			// Token: 0x0400422E RID: 16942
			private static readonly IntPtr NativeMethodInfoPtr_Peek_Public_Virtual_Int32_0;

			// Token: 0x0400422F RID: 16943
			private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Virtual_Int32_0;

			// Token: 0x04004230 RID: 16944
			private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Virtual_Int32_Il2CppStructArray_1_Char_Int32_Int32_0;

			// Token: 0x04004231 RID: 16945
			private static readonly IntPtr NativeMethodInfoPtr_ReadLine_Public_Virtual_String_0;

			// Token: 0x04004232 RID: 16946
			private static readonly IntPtr NativeMethodInfoPtr_ReadToEnd_Public_Virtual_String_0;
		}

		// Token: 0x020005D6 RID: 1494
		[ObfuscatedName("System.IO.TextReader+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x060051CA RID: 20938 RVA: 0x0016D608 File Offset: 0x0016B808
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<TextReader.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TextReader>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextReader.__c>.NativeClassPtr);
				TextReader.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextReader.__c>.NativeClassPtr, "<>9");
				TextReader.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextReader.__c>.NativeClassPtr, 100669001);
				TextReader.__c.NativeMethodInfoPtr___cctor_b__22_0_Internal_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextReader.__c>.NativeClassPtr, 100669002);
				TextReader.__c.NativeMethodInfoPtr___cctor_b__22_1_Internal_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextReader.__c>.NativeClassPtr, 100669003);
			}

			// Token: 0x060051CB RID: 20939 RVA: 0x0016D684 File Offset: 0x0016B884
			[CallerCount(817)]
			[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextReader.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextReader.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060051CC RID: 20940 RVA: 0x0016D6C0 File Offset: 0x0016B8C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 322107, XrefRangeEnd = 322111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string __cctor_b__22_0(Object state)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(state);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextReader.__c.NativeMethodInfoPtr___cctor_b__22_0_Internal_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x060051CD RID: 20941 RVA: 0x0016D708 File Offset: 0x0016B908
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 322111, XrefRangeEnd = 322117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int __cctor_b__22_1(Object state)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(state);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextReader.__c.NativeMethodInfoPtr___cctor_b__22_1_Internal_Int32_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060051CE RID: 20942 RVA: 0x0001F304 File Offset: 0x0001D504
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170014EA RID: 5354
			// (get) Token: 0x060051CF RID: 20943 RVA: 0x0016D758 File Offset: 0x0016B958
			// (set) Token: 0x060051D0 RID: 20944 RVA: 0x0001F30D File Offset: 0x0001D50D
			public unsafe static TextReader.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TextReader.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextReader.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TextReader.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004233 RID: 16947
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04004234 RID: 16948
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04004235 RID: 16949
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__22_0_Internal_String_Object_0;

			// Token: 0x04004236 RID: 16950
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__22_1_Internal_Int32_Object_0;
		}
	}
}
