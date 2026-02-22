using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Runtime.Serialization
{
	// Token: 0x0200034B RID: 843
	public sealed class SerializationObjectManager : Object
	{
		// Token: 0x06003638 RID: 13880 RVA: 0x00107938 File Offset: 0x00105B38
		// Note: this type is marked as 'beforefieldinit'.
		static SerializationObjectManager()
		{
			Il2CppClassPointerStore<SerializationObjectManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization", "SerializationObjectManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializationObjectManager>.NativeClassPtr);
			SerializationObjectManager.NativeFieldInfoPtr_m_objectSeenTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializationObjectManager>.NativeClassPtr, "m_objectSeenTable");
			SerializationObjectManager.NativeFieldInfoPtr_m_onSerializedHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializationObjectManager>.NativeClassPtr, "m_onSerializedHandler");
			SerializationObjectManager.NativeFieldInfoPtr_m_context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializationObjectManager>.NativeClassPtr, "m_context");
			SerializationObjectManager.NativeMethodInfoPtr__ctor_Public_Void_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationObjectManager>.NativeClassPtr, 100671652);
			SerializationObjectManager.NativeMethodInfoPtr_RegisterObject_Public_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationObjectManager>.NativeClassPtr, 100671653);
			SerializationObjectManager.NativeMethodInfoPtr_RaiseOnSerializedEvent_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationObjectManager>.NativeClassPtr, 100671654);
			SerializationObjectManager.NativeMethodInfoPtr_AddOnSerialized_Private_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationObjectManager>.NativeClassPtr, 100671655);
		}

		// Token: 0x06003639 RID: 13881 RVA: 0x001079F4 File Offset: 0x00105BF4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 344788, RefRangeEnd = 344789, XrefRangeStart = 344780, XrefRangeEnd = 344788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializationObjectManager(StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializationObjectManager>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationObjectManager.NativeMethodInfoPtr__ctor_Public_Void_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600363A RID: 13882 RVA: 0x00107A44 File Offset: 0x00105C44
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 344804, RefRangeEnd = 344805, XrefRangeStart = 344789, XrefRangeEnd = 344804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterObject(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationObjectManager.NativeMethodInfoPtr_RegisterObject_Public_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600363B RID: 13883 RVA: 0x00107A88 File Offset: 0x00105C88
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 344806, RefRangeEnd = 344807, XrefRangeStart = 344805, XrefRangeEnd = 344806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RaiseOnSerializedEvent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationObjectManager.NativeMethodInfoPtr_RaiseOnSerializedEvent_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600363C RID: 13884 RVA: 0x00107ABC File Offset: 0x00105CBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 344807, XrefRangeEnd = 344813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddOnSerialized(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationObjectManager.NativeMethodInfoPtr_AddOnSerialized_Private_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600363D RID: 13885 RVA: 0x000137AB File Offset: 0x000119AB
		public SerializationObjectManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000D21 RID: 3361
		// (get) Token: 0x0600363E RID: 13886 RVA: 0x00107B00 File Offset: 0x00105D00
		// (set) Token: 0x0600363F RID: 13887 RVA: 0x000137B4 File Offset: 0x000119B4
		public unsafe Hashtable m_objectSeenTable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationObjectManager.NativeFieldInfoPtr_m_objectSeenTable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationObjectManager.NativeFieldInfoPtr_m_objectSeenTable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D22 RID: 3362
		// (get) Token: 0x06003640 RID: 13888 RVA: 0x00107B30 File Offset: 0x00105D30
		// (set) Token: 0x06003641 RID: 13889 RVA: 0x000137D3 File Offset: 0x000119D3
		public unsafe SerializationEventHandler m_onSerializedHandler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationObjectManager.NativeFieldInfoPtr_m_onSerializedHandler);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerializationEventHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationObjectManager.NativeFieldInfoPtr_m_onSerializedHandler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D23 RID: 3363
		// (get) Token: 0x06003642 RID: 13890 RVA: 0x00107B60 File Offset: 0x00105D60
		// (set) Token: 0x06003643 RID: 13891 RVA: 0x000137F2 File Offset: 0x000119F2
		public StreamingContext m_context
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationObjectManager.NativeFieldInfoPtr_m_context);
				return new StreamingContext(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StreamingContext>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationObjectManager.NativeFieldInfoPtr_m_context), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<StreamingContext>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x04002DAF RID: 11695
		private static readonly IntPtr NativeFieldInfoPtr_m_objectSeenTable;

		// Token: 0x04002DB0 RID: 11696
		private static readonly IntPtr NativeFieldInfoPtr_m_onSerializedHandler;

		// Token: 0x04002DB1 RID: 11697
		private static readonly IntPtr NativeFieldInfoPtr_m_context;

		// Token: 0x04002DB2 RID: 11698
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_StreamingContext_0;

		// Token: 0x04002DB3 RID: 11699
		private static readonly IntPtr NativeMethodInfoPtr_RegisterObject_Public_Void_Object_0;

		// Token: 0x04002DB4 RID: 11700
		private static readonly IntPtr NativeMethodInfoPtr_RaiseOnSerializedEvent_Public_Void_0;

		// Token: 0x04002DB5 RID: 11701
		private static readonly IntPtr NativeMethodInfoPtr_AddOnSerialized_Private_Void_Object_0;
	}
}
