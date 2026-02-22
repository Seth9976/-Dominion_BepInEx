using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.IO;
using Il2CppSystem.Runtime.Remoting.Messaging;

namespace Il2CppSystem.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x02000376 RID: 886
	public sealed class BinaryFormatter : Object
	{
		// Token: 0x0600381A RID: 14362 RVA: 0x0010D210 File Offset: 0x0010B410
		// Note: this type is marked as 'beforefieldinit'.
		static BinaryFormatter()
		{
			Il2CppClassPointerStore<BinaryFormatter>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization.Formatters.Binary", "BinaryFormatter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BinaryFormatter>.NativeClassPtr);
			BinaryFormatter.NativeFieldInfoPtr_m_surrogates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryFormatter>.NativeClassPtr, "m_surrogates");
			BinaryFormatter.NativeFieldInfoPtr_m_context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryFormatter>.NativeClassPtr, "m_context");
			BinaryFormatter.NativeFieldInfoPtr_m_binder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryFormatter>.NativeClassPtr, "m_binder");
			BinaryFormatter.NativeFieldInfoPtr_m_typeFormat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryFormatter>.NativeClassPtr, "m_typeFormat");
			BinaryFormatter.NativeFieldInfoPtr_m_assemblyFormat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryFormatter>.NativeClassPtr, "m_assemblyFormat");
			BinaryFormatter.NativeFieldInfoPtr_m_securityLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryFormatter>.NativeClassPtr, "m_securityLevel");
			BinaryFormatter.NativeFieldInfoPtr_m_crossAppDomainArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryFormatter>.NativeClassPtr, "m_crossAppDomainArray");
			BinaryFormatter.NativeFieldInfoPtr_typeNameCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryFormatter>.NativeClassPtr, "typeNameCache");
			BinaryFormatter.NativeMethodInfoPtr_set_AssemblyFormat_Public_set_Void_FormatterAssemblyStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryFormatter>.NativeClassPtr, 100671782);
			BinaryFormatter.NativeMethodInfoPtr_set_SurrogateSelector_Public_Virtual_Final_New_set_Void_ISurrogateSelector_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryFormatter>.NativeClassPtr, 100671783);
			BinaryFormatter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryFormatter>.NativeClassPtr, 100671784);
			BinaryFormatter.NativeMethodInfoPtr__ctor_Public_Void_ISurrogateSelector_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryFormatter>.NativeClassPtr, 100671785);
			BinaryFormatter.NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Object_Stream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryFormatter>.NativeClassPtr, 100671786);
			BinaryFormatter.NativeMethodInfoPtr_Deserialize_Internal_Object_Stream_HeaderHandler_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryFormatter>.NativeClassPtr, 100671787);
			BinaryFormatter.NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Object_Stream_HeaderHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryFormatter>.NativeClassPtr, 100671788);
			BinaryFormatter.NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Void_Stream_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryFormatter>.NativeClassPtr, 100671789);
			BinaryFormatter.NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Void_Stream_Object_Il2CppReferenceArray_1_Header_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryFormatter>.NativeClassPtr, 100671790);
			BinaryFormatter.NativeMethodInfoPtr_Serialize_Internal_Void_Stream_Object_Il2CppReferenceArray_1_Header_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryFormatter>.NativeClassPtr, 100671791);
			BinaryFormatter.NativeMethodInfoPtr_GetTypeInformation_Internal_Static_TypeInformation_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryFormatter>.NativeClassPtr, 100671792);
		}

		// Token: 0x17000DC4 RID: 3524
		// (set) Token: 0x0600381B RID: 14363 RVA: 0x0010D3BC File Offset: 0x0010B5BC
		public unsafe FormatterAssemblyStyle AssemblyFormat
		{
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryFormatter.NativeMethodInfoPtr_set_AssemblyFormat_Public_set_Void_FormatterAssemblyStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000DC5 RID: 3525
		// (set) Token: 0x0600381C RID: 14364 RVA: 0x0010D3FC File Offset: 0x0010B5FC
		public unsafe ISurrogateSelector SurrogateSelector
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 5326, RefRangeEnd = 5327, XrefRangeStart = 5326, XrefRangeEnd = 5327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryFormatter.NativeMethodInfoPtr_set_SurrogateSelector_Public_Virtual_Final_New_set_Void_ISurrogateSelector_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600381D RID: 14365 RVA: 0x0010D440 File Offset: 0x0010B640
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 345572, RefRangeEnd = 345580, XrefRangeStart = 345570, XrefRangeEnd = 345572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BinaryFormatter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BinaryFormatter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryFormatter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600381E RID: 14366 RVA: 0x0010D47C File Offset: 0x0010B67C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 345581, RefRangeEnd = 345583, XrefRangeStart = 345580, XrefRangeEnd = 345581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BinaryFormatter(ISurrogateSelector selector, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BinaryFormatter>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(selector);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryFormatter.NativeMethodInfoPtr__ctor_Public_Void_ISurrogateSelector_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600381F RID: 14367 RVA: 0x0010D4E0 File Offset: 0x0010B6E0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 345584, RefRangeEnd = 345589, XrefRangeStart = 345583, XrefRangeEnd = 345584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object Deserialize(Stream serializationStream)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serializationStream);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryFormatter.NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Object_Stream_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06003820 RID: 14368 RVA: 0x0010D530 File Offset: 0x0010B730
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 345623, RefRangeEnd = 345629, XrefRangeStart = 345589, XrefRangeEnd = 345623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object Deserialize(Stream serializationStream, HeaderHandler handler, bool fCheck)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serializationStream);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(handler);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fCheck;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryFormatter.NativeMethodInfoPtr_Deserialize_Internal_Object_Stream_HeaderHandler_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06003821 RID: 14369 RVA: 0x0010D5A0 File Offset: 0x0010B7A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 345629, XrefRangeEnd = 345630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object Deserialize(Stream serializationStream, HeaderHandler handler)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serializationStream);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(handler);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryFormatter.NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Object_Stream_HeaderHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06003822 RID: 14370 RVA: 0x0010D604 File Offset: 0x0010B804
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 345631, RefRangeEnd = 345636, XrefRangeStart = 345630, XrefRangeEnd = 345631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Serialize(Stream serializationStream, Object graph)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serializationStream);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(graph);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryFormatter.NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Void_Stream_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003823 RID: 14371 RVA: 0x0010D658 File Offset: 0x0010B858
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 345636, XrefRangeEnd = 345637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Serialize(Stream serializationStream, Object graph, Il2CppReferenceArray<Header> headers)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serializationStream);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(graph);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(headers);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryFormatter.NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Void_Stream_Object_Il2CppReferenceArray_1_Header_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003824 RID: 14372 RVA: 0x0010D6C0 File Offset: 0x0010B8C0
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 345650, RefRangeEnd = 345657, XrefRangeStart = 345637, XrefRangeEnd = 345650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Serialize(Stream serializationStream, Object graph, Il2CppReferenceArray<Header> headers, bool fCheck)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serializationStream);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(graph);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(headers);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fCheck;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryFormatter.NativeMethodInfoPtr_Serialize_Internal_Void_Stream_Object_Il2CppReferenceArray_1_Header_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003825 RID: 14373 RVA: 0x0010D734 File Offset: 0x0010B934
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 345685, RefRangeEnd = 345689, XrefRangeStart = 345657, XrefRangeEnd = 345685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TypeInformation GetTypeInformation(Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryFormatter.NativeMethodInfoPtr_GetTypeInformation_Internal_Static_TypeInformation_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TypeInformation>(intPtr3) : null;
			}
		}

		// Token: 0x06003826 RID: 14374 RVA: 0x000147AA File Offset: 0x000129AA
		public BinaryFormatter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000DBC RID: 3516
		// (get) Token: 0x06003827 RID: 14375 RVA: 0x0010D778 File Offset: 0x0010B978
		// (set) Token: 0x06003828 RID: 14376 RVA: 0x000147B3 File Offset: 0x000129B3
		public unsafe ISurrogateSelector m_surrogates
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryFormatter.NativeFieldInfoPtr_m_surrogates);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ISurrogateSelector>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryFormatter.NativeFieldInfoPtr_m_surrogates), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DBD RID: 3517
		// (get) Token: 0x06003829 RID: 14377 RVA: 0x0010D7A8 File Offset: 0x0010B9A8
		// (set) Token: 0x0600382A RID: 14378 RVA: 0x000147D2 File Offset: 0x000129D2
		public StreamingContext m_context
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryFormatter.NativeFieldInfoPtr_m_context);
				return new StreamingContext(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StreamingContext>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryFormatter.NativeFieldInfoPtr_m_context), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<StreamingContext>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000DBE RID: 3518
		// (get) Token: 0x0600382B RID: 14379 RVA: 0x0010D7D8 File Offset: 0x0010B9D8
		// (set) Token: 0x0600382C RID: 14380 RVA: 0x00014800 File Offset: 0x00012A00
		public unsafe SerializationBinder m_binder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryFormatter.NativeFieldInfoPtr_m_binder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerializationBinder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryFormatter.NativeFieldInfoPtr_m_binder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DBF RID: 3519
		// (get) Token: 0x0600382D RID: 14381 RVA: 0x0010D808 File Offset: 0x0010BA08
		// (set) Token: 0x0600382E RID: 14382 RVA: 0x0001481F File Offset: 0x00012A1F
		public unsafe FormatterTypeStyle m_typeFormat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryFormatter.NativeFieldInfoPtr_m_typeFormat);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryFormatter.NativeFieldInfoPtr_m_typeFormat)) = value;
			}
		}

		// Token: 0x17000DC0 RID: 3520
		// (get) Token: 0x0600382F RID: 14383 RVA: 0x0010D830 File Offset: 0x0010BA30
		// (set) Token: 0x06003830 RID: 14384 RVA: 0x0001483A File Offset: 0x00012A3A
		public unsafe FormatterAssemblyStyle m_assemblyFormat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryFormatter.NativeFieldInfoPtr_m_assemblyFormat);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryFormatter.NativeFieldInfoPtr_m_assemblyFormat)) = value;
			}
		}

		// Token: 0x17000DC1 RID: 3521
		// (get) Token: 0x06003831 RID: 14385 RVA: 0x0010D858 File Offset: 0x0010BA58
		// (set) Token: 0x06003832 RID: 14386 RVA: 0x00014855 File Offset: 0x00012A55
		public unsafe TypeFilterLevel m_securityLevel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryFormatter.NativeFieldInfoPtr_m_securityLevel);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryFormatter.NativeFieldInfoPtr_m_securityLevel)) = value;
			}
		}

		// Token: 0x17000DC2 RID: 3522
		// (get) Token: 0x06003833 RID: 14387 RVA: 0x0010D880 File Offset: 0x0010BA80
		// (set) Token: 0x06003834 RID: 14388 RVA: 0x00014870 File Offset: 0x00012A70
		public unsafe Il2CppReferenceArray<Object> m_crossAppDomainArray
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryFormatter.NativeFieldInfoPtr_m_crossAppDomainArray);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryFormatter.NativeFieldInfoPtr_m_crossAppDomainArray), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DC3 RID: 3523
		// (get) Token: 0x06003835 RID: 14389 RVA: 0x0010D8B0 File Offset: 0x0010BAB0
		// (set) Token: 0x06003836 RID: 14390 RVA: 0x0001488F File Offset: 0x00012A8F
		public unsafe static Dictionary<Type, TypeInformation> typeNameCache
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BinaryFormatter.NativeFieldInfoPtr_typeNameCache, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Type, TypeInformation>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BinaryFormatter.NativeFieldInfoPtr_typeNameCache, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002F55 RID: 12117
		private static readonly IntPtr NativeFieldInfoPtr_m_surrogates;

		// Token: 0x04002F56 RID: 12118
		private static readonly IntPtr NativeFieldInfoPtr_m_context;

		// Token: 0x04002F57 RID: 12119
		private static readonly IntPtr NativeFieldInfoPtr_m_binder;

		// Token: 0x04002F58 RID: 12120
		private static readonly IntPtr NativeFieldInfoPtr_m_typeFormat;

		// Token: 0x04002F59 RID: 12121
		private static readonly IntPtr NativeFieldInfoPtr_m_assemblyFormat;

		// Token: 0x04002F5A RID: 12122
		private static readonly IntPtr NativeFieldInfoPtr_m_securityLevel;

		// Token: 0x04002F5B RID: 12123
		private static readonly IntPtr NativeFieldInfoPtr_m_crossAppDomainArray;

		// Token: 0x04002F5C RID: 12124
		private static readonly IntPtr NativeFieldInfoPtr_typeNameCache;

		// Token: 0x04002F5D RID: 12125
		private static readonly IntPtr NativeMethodInfoPtr_set_AssemblyFormat_Public_set_Void_FormatterAssemblyStyle_0;

		// Token: 0x04002F5E RID: 12126
		private static readonly IntPtr NativeMethodInfoPtr_set_SurrogateSelector_Public_Virtual_Final_New_set_Void_ISurrogateSelector_0;

		// Token: 0x04002F5F RID: 12127
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002F60 RID: 12128
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ISurrogateSelector_StreamingContext_0;

		// Token: 0x04002F61 RID: 12129
		private static readonly IntPtr NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Object_Stream_0;

		// Token: 0x04002F62 RID: 12130
		private static readonly IntPtr NativeMethodInfoPtr_Deserialize_Internal_Object_Stream_HeaderHandler_Boolean_0;

		// Token: 0x04002F63 RID: 12131
		private static readonly IntPtr NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Object_Stream_HeaderHandler_0;

		// Token: 0x04002F64 RID: 12132
		private static readonly IntPtr NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Void_Stream_Object_0;

		// Token: 0x04002F65 RID: 12133
		private static readonly IntPtr NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Void_Stream_Object_Il2CppReferenceArray_1_Header_0;

		// Token: 0x04002F66 RID: 12134
		private static readonly IntPtr NativeMethodInfoPtr_Serialize_Internal_Void_Stream_Object_Il2CppReferenceArray_1_Header_Boolean_0;

		// Token: 0x04002F67 RID: 12135
		private static readonly IntPtr NativeMethodInfoPtr_GetTypeInformation_Internal_Static_TypeInformation_Type_0;
	}
}
