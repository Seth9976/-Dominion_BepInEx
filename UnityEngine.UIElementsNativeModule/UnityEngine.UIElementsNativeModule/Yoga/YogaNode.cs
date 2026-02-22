using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.Yoga
{
	// Token: 0x02000009 RID: 9
	public class YogaNode : Object
	{
		// Token: 0x0600008D RID: 141 RVA: 0x00003B5C File Offset: 0x00001D5C
		// Note: this type is marked as 'beforefieldinit'.
		static YogaNode()
		{
			Il2CppClassPointerStore<YogaNode>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsNativeModule.dll", "UnityEngine.Yoga", "YogaNode");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<YogaNode>.NativeClassPtr);
			YogaNode.NativeFieldInfoPtr__ygNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YogaNode>.NativeClassPtr, "_ygNode");
			YogaNode.NativeFieldInfoPtr__config = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YogaNode>.NativeClassPtr, "_config");
			YogaNode.NativeFieldInfoPtr__parent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YogaNode>.NativeClassPtr, "_parent");
			YogaNode.NativeFieldInfoPtr__children = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YogaNode>.NativeClassPtr, "_children");
			YogaNode.NativeFieldInfoPtr__measureFunction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YogaNode>.NativeClassPtr, "_measureFunction");
			YogaNode.NativeFieldInfoPtr__baselineFunction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YogaNode>.NativeClassPtr, "_baselineFunction");
			YogaNode.NativeFieldInfoPtr__data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YogaNode>.NativeClassPtr, "_data");
			YogaNode.NativeMethodInfoPtr_get_LayoutX_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YogaNode>.NativeClassPtr, 100663318);
			YogaNode.NativeMethodInfoPtr_get_LayoutY_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YogaNode>.NativeClassPtr, 100663319);
			YogaNode.NativeMethodInfoPtr_get_LayoutWidth_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YogaNode>.NativeClassPtr, 100663320);
			YogaNode.NativeMethodInfoPtr_get_LayoutHeight_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YogaNode>.NativeClassPtr, 100663321);
			YogaNode.NativeMethodInfoPtr_MeasureInternal_Public_Static_YogaSize_YogaNode_Single_YogaMeasureMode_Single_YogaMeasureMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YogaNode>.NativeClassPtr, 100663322);
			YogaNode.NativeMethodInfoPtr_BaselineInternal_Public_Static_Single_YogaNode_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YogaNode>.NativeClassPtr, 100663323);
			YogaNode.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_YogaNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YogaNode>.NativeClassPtr, 100663324);
			YogaNode.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YogaNode>.NativeClassPtr, 100663325);
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600008E RID: 142 RVA: 0x00003CB8 File Offset: 0x00001EB8
		public unsafe float LayoutX
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 89425, RefRangeEnd = 89426, XrefRangeStart = 89423, XrefRangeEnd = 89425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YogaNode.NativeMethodInfoPtr_get_LayoutX_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600008F RID: 143 RVA: 0x00003CF4 File Offset: 0x00001EF4
		public unsafe float LayoutY
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 89428, RefRangeEnd = 89429, XrefRangeStart = 89426, XrefRangeEnd = 89428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YogaNode.NativeMethodInfoPtr_get_LayoutY_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000090 RID: 144 RVA: 0x00003D30 File Offset: 0x00001F30
		public unsafe float LayoutWidth
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 89431, RefRangeEnd = 89432, XrefRangeStart = 89429, XrefRangeEnd = 89431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YogaNode.NativeMethodInfoPtr_get_LayoutWidth_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000091 RID: 145 RVA: 0x00003D6C File Offset: 0x00001F6C
		public unsafe float LayoutHeight
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 89434, RefRangeEnd = 89435, XrefRangeStart = 89432, XrefRangeEnd = 89434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YogaNode.NativeMethodInfoPtr_get_LayoutHeight_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000092 RID: 146 RVA: 0x00003DA8 File Offset: 0x00001FA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89435, XrefRangeEnd = 89436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static YogaSize MeasureInternal(YogaNode node, float width, YogaMeasureMode widthMode, float height, YogaMeasureMode heightMode)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref width;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref widthMode;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref heightMode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YogaNode.NativeMethodInfoPtr_MeasureInternal_Public_Static_YogaSize_YogaNode_Single_YogaMeasureMode_Single_YogaMeasureMode_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000093 RID: 147 RVA: 0x00003E24 File Offset: 0x00002024
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89436, XrefRangeEnd = 89437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float BaselineInternal(YogaNode node, float width, float height)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref width;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YogaNode.NativeMethodInfoPtr_BaselineInternal_Public_Static_Single_YogaNode_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000094 RID: 148 RVA: 0x00003E84 File Offset: 0x00002084
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89437, XrefRangeEnd = 89443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator<YogaNode> GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YogaNode.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_YogaNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<YogaNode>>(intPtr3) : null;
		}

		// Token: 0x06000095 RID: 149 RVA: 0x00003EC4 File Offset: 0x000020C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89443, XrefRangeEnd = 89449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator System_Collections_IEnumerable_GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YogaNode.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000096 RID: 150 RVA: 0x00002614 File Offset: 0x00000814
		public YogaNode(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000097 RID: 151 RVA: 0x00003F04 File Offset: 0x00002104
		// (set) Token: 0x06000098 RID: 152 RVA: 0x0000261D File Offset: 0x0000081D
		public unsafe IntPtr _ygNode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YogaNode.NativeFieldInfoPtr__ygNode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YogaNode.NativeFieldInfoPtr__ygNode)) = value;
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000099 RID: 153 RVA: 0x00003F2C File Offset: 0x0000212C
		// (set) Token: 0x0600009A RID: 154 RVA: 0x00002638 File Offset: 0x00000838
		public unsafe YogaConfig _config
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YogaNode.NativeFieldInfoPtr__config);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<YogaConfig>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(YogaNode.NativeFieldInfoPtr__config), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600009B RID: 155 RVA: 0x00003F5C File Offset: 0x0000215C
		// (set) Token: 0x0600009C RID: 156 RVA: 0x00002657 File Offset: 0x00000857
		public unsafe WeakReference _parent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YogaNode.NativeFieldInfoPtr__parent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WeakReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(YogaNode.NativeFieldInfoPtr__parent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x0600009D RID: 157 RVA: 0x00003F8C File Offset: 0x0000218C
		// (set) Token: 0x0600009E RID: 158 RVA: 0x00002676 File Offset: 0x00000876
		public unsafe List<YogaNode> _children
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YogaNode.NativeFieldInfoPtr__children);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<YogaNode>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(YogaNode.NativeFieldInfoPtr__children), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x0600009F RID: 159 RVA: 0x00003FBC File Offset: 0x000021BC
		// (set) Token: 0x060000A0 RID: 160 RVA: 0x00002695 File Offset: 0x00000895
		public unsafe MeasureFunction _measureFunction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YogaNode.NativeFieldInfoPtr__measureFunction);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeasureFunction>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(YogaNode.NativeFieldInfoPtr__measureFunction), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x060000A1 RID: 161 RVA: 0x00003FEC File Offset: 0x000021EC
		// (set) Token: 0x060000A2 RID: 162 RVA: 0x000026B4 File Offset: 0x000008B4
		public unsafe BaselineFunction _baselineFunction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YogaNode.NativeFieldInfoPtr__baselineFunction);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BaselineFunction>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(YogaNode.NativeFieldInfoPtr__baselineFunction), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x060000A3 RID: 163 RVA: 0x0000401C File Offset: 0x0000221C
		// (set) Token: 0x060000A4 RID: 164 RVA: 0x000026D3 File Offset: 0x000008D3
		public unsafe Object _data
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YogaNode.NativeFieldInfoPtr__data);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(YogaNode.NativeFieldInfoPtr__data), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x0000404C File Offset: 0x0000224C
		public ~YogaNode()
		{
			Native.YGNodeFree(this._ygNode);
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x000026F2 File Offset: 0x000008F2
		public void Reset()
		{
			this._measureFunction = null;
			this._baselineFunction = null;
			this._data = null;
			Native.YGSetManagedObject(this._ygNode, null);
			Native.YGNodeReset(this._ygNode);
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x060000A7 RID: 167 RVA: 0x00004084 File Offset: 0x00002284
		// (set) Token: 0x060000A8 RID: 168 RVA: 0x00002723 File Offset: 0x00000923
		public YogaConfig Config
		{
			get
			{
				return this._config;
			}
			set
			{
				this._config = value ?? YogaConfig.Default;
				Native.YGNodeSetConfig(this._ygNode, this._config.Handle);
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x060000A9 RID: 169 RVA: 0x0000409C File Offset: 0x0000229C
		public bool IsDirty
		{
			get
			{
				return Native.YGNodeIsDirty(this._ygNode);
			}
		}

		// Token: 0x060000AA RID: 170 RVA: 0x0000274D File Offset: 0x0000094D
		public virtual void MarkDirty()
		{
			Native.YGNodeMarkDirty(this._ygNode);
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x060000AB RID: 171 RVA: 0x000040BC File Offset: 0x000022BC
		public bool HasNewLayout
		{
			get
			{
				return Native.YGNodeGetHasNewLayout(this._ygNode);
			}
		}

		// Token: 0x060000AC RID: 172 RVA: 0x0000275C File Offset: 0x0000095C
		public void MarkHasNewLayout()
		{
			Native.YGNodeSetHasNewLayout(this._ygNode, true);
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x060000AD RID: 173 RVA: 0x000040DC File Offset: 0x000022DC
		public YogaNode Parent
		{
			get
			{
				return (this._parent != null) ? this._parent.Target.TryCast<YogaNode>() : null;
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x060000AE RID: 174 RVA: 0x0000410C File Offset: 0x0000230C
		public bool IsMeasureDefined
		{
			get
			{
				return this._measureFunction != null;
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x060000AF RID: 175 RVA: 0x00004128 File Offset: 0x00002328
		public bool IsBaselineDefined
		{
			get
			{
				return this._baselineFunction != null;
			}
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x0000276C File Offset: 0x0000096C
		public void CopyStyle(YogaNode srcNode)
		{
			Native.YGNodeCopyStyle(this._ygNode, srcNode._ygNode);
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x060000B1 RID: 177 RVA: 0x00004144 File Offset: 0x00002344
		// (set) Token: 0x060000B2 RID: 178 RVA: 0x00002781 File Offset: 0x00000981
		public YogaDirection StyleDirection
		{
			get
			{
				return Native.YGNodeStyleGetDirection(this._ygNode);
			}
			set
			{
				Native.YGNodeStyleSetDirection(this._ygNode, value);
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x060000B3 RID: 179 RVA: 0x00004164 File Offset: 0x00002364
		// (set) Token: 0x060000B4 RID: 180 RVA: 0x00002791 File Offset: 0x00000991
		public YogaFlexDirection FlexDirection
		{
			get
			{
				return Native.YGNodeStyleGetFlexDirection(this._ygNode);
			}
			set
			{
				Native.YGNodeStyleSetFlexDirection(this._ygNode, value);
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x060000B5 RID: 181 RVA: 0x00004184 File Offset: 0x00002384
		// (set) Token: 0x060000B6 RID: 182 RVA: 0x000027A1 File Offset: 0x000009A1
		public YogaJustify JustifyContent
		{
			get
			{
				return Native.YGNodeStyleGetJustifyContent(this._ygNode);
			}
			set
			{
				Native.YGNodeStyleSetJustifyContent(this._ygNode, value);
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x060000B7 RID: 183 RVA: 0x000041A4 File Offset: 0x000023A4
		// (set) Token: 0x060000B8 RID: 184 RVA: 0x000027B1 File Offset: 0x000009B1
		public YogaDisplay Display
		{
			get
			{
				return Native.YGNodeStyleGetDisplay(this._ygNode);
			}
			set
			{
				Native.YGNodeStyleSetDisplay(this._ygNode, value);
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x060000B9 RID: 185 RVA: 0x000041C4 File Offset: 0x000023C4
		// (set) Token: 0x060000BA RID: 186 RVA: 0x000027C1 File Offset: 0x000009C1
		public YogaAlign AlignItems
		{
			get
			{
				return Native.YGNodeStyleGetAlignItems(this._ygNode);
			}
			set
			{
				Native.YGNodeStyleSetAlignItems(this._ygNode, value);
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x060000BB RID: 187 RVA: 0x000041E4 File Offset: 0x000023E4
		// (set) Token: 0x060000BC RID: 188 RVA: 0x000027D1 File Offset: 0x000009D1
		public YogaAlign AlignSelf
		{
			get
			{
				return Native.YGNodeStyleGetAlignSelf(this._ygNode);
			}
			set
			{
				Native.YGNodeStyleSetAlignSelf(this._ygNode, value);
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x060000BD RID: 189 RVA: 0x00004204 File Offset: 0x00002404
		// (set) Token: 0x060000BE RID: 190 RVA: 0x000027E1 File Offset: 0x000009E1
		public YogaAlign AlignContent
		{
			get
			{
				return Native.YGNodeStyleGetAlignContent(this._ygNode);
			}
			set
			{
				Native.YGNodeStyleSetAlignContent(this._ygNode, value);
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x060000BF RID: 191 RVA: 0x00004224 File Offset: 0x00002424
		// (set) Token: 0x060000C0 RID: 192 RVA: 0x000027F1 File Offset: 0x000009F1
		public YogaPositionType PositionType
		{
			get
			{
				return Native.YGNodeStyleGetPositionType(this._ygNode);
			}
			set
			{
				Native.YGNodeStyleSetPositionType(this._ygNode, value);
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x060000C1 RID: 193 RVA: 0x00004244 File Offset: 0x00002444
		// (set) Token: 0x060000C2 RID: 194 RVA: 0x00002801 File Offset: 0x00000A01
		public YogaWrap Wrap
		{
			get
			{
				return Native.YGNodeStyleGetFlexWrap(this._ygNode);
			}
			set
			{
				Native.YGNodeStyleSetFlexWrap(this._ygNode, value);
			}
		}

		// Token: 0x17000022 RID: 34
		// (set) Token: 0x060000C3 RID: 195 RVA: 0x00002811 File Offset: 0x00000A11
		public float Flex
		{
			set
			{
				Native.YGNodeStyleSetFlex(this._ygNode, value);
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x060000C4 RID: 196 RVA: 0x00004264 File Offset: 0x00002464
		// (set) Token: 0x060000C5 RID: 197 RVA: 0x00002821 File Offset: 0x00000A21
		public float FlexGrow
		{
			get
			{
				return Native.YGNodeStyleGetFlexGrow(this._ygNode);
			}
			set
			{
				Native.YGNodeStyleSetFlexGrow(this._ygNode, value);
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x060000C6 RID: 198 RVA: 0x00004284 File Offset: 0x00002484
		// (set) Token: 0x060000C7 RID: 199 RVA: 0x00002831 File Offset: 0x00000A31
		public float FlexShrink
		{
			get
			{
				return Native.YGNodeStyleGetFlexShrink(this._ygNode);
			}
			set
			{
				Native.YGNodeStyleSetFlexShrink(this._ygNode, value);
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x060000C8 RID: 200 RVA: 0x000042A4 File Offset: 0x000024A4
		// (set) Token: 0x060000C9 RID: 201 RVA: 0x00002841 File Offset: 0x00000A41
		public float AspectRatio
		{
			get
			{
				return Native.YGNodeStyleGetAspectRatio(this._ygNode);
			}
			set
			{
				Native.YGNodeStyleSetAspectRatio(this._ygNode, value);
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x060000CA RID: 202 RVA: 0x000042C4 File Offset: 0x000024C4
		public float LayoutRight
		{
			get
			{
				return Native.YGNodeLayoutGetRight(this._ygNode);
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x060000CB RID: 203 RVA: 0x000042E4 File Offset: 0x000024E4
		public float LayoutBottom
		{
			get
			{
				return Native.YGNodeLayoutGetBottom(this._ygNode);
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x060000CC RID: 204 RVA: 0x00004304 File Offset: 0x00002504
		public YogaDirection LayoutDirection
		{
			get
			{
				return Native.YGNodeLayoutGetDirection(this._ygNode);
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x060000CD RID: 205 RVA: 0x00004324 File Offset: 0x00002524
		// (set) Token: 0x060000CE RID: 206 RVA: 0x00002851 File Offset: 0x00000A51
		public YogaOverflow Overflow
		{
			get
			{
				return Native.YGNodeStyleGetOverflow(this._ygNode);
			}
			set
			{
				Native.YGNodeStyleSetOverflow(this._ygNode, value);
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060000CF RID: 207 RVA: 0x00004344 File Offset: 0x00002544
		// (set) Token: 0x060000D0 RID: 208 RVA: 0x00002861 File Offset: 0x00000A61
		public Object Data
		{
			get
			{
				return this._data;
			}
			set
			{
				this._data = value;
			}
		}

		// Token: 0x1700002B RID: 43
		public YogaNode this[int index]
		{
			get
			{
				return this._children[index];
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060000D2 RID: 210 RVA: 0x0000437C File Offset: 0x0000257C
		public int Count
		{
			get
			{
				return (this._children != null) ? this._children.Count : 0;
			}
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x0000286B File Offset: 0x00000A6B
		public void MarkLayoutSeen()
		{
			Native.YGNodeSetHasNewLayout(this._ygNode, false);
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x000043A4 File Offset: 0x000025A4
		public bool ValuesEqual(float f1, float f2)
		{
			bool flag = Single.IsNaN(f1) || Single.IsNaN(f2);
			bool flag2;
			if (flag)
			{
				flag2 = Single.IsNaN(f1) && Single.IsNaN(f2);
			}
			else
			{
				flag2 = Math.Abs(f2 - f1) < float.Epsilon;
			}
			return flag2;
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x000043F0 File Offset: 0x000025F0
		public void Insert(int index, YogaNode node)
		{
			bool flag = this._children == null;
			if (flag)
			{
				this._children = new List<YogaNode>(4);
			}
			this._children.Insert(index, node);
			node._parent = new WeakReference(this);
			Native.YGNodeInsertChild(this._ygNode, node._ygNode, (uint)index);
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x00004448 File Offset: 0x00002648
		public void RemoveAt(int index)
		{
			YogaNode yogaNode = this._children[index];
			yogaNode._parent = null;
			this._children.RemoveAt(index);
			Native.YGNodeRemoveChild(this._ygNode, yogaNode._ygNode);
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x0000287B File Offset: 0x00000A7B
		public void AddChild(YogaNode child)
		{
			this.Insert(this.Count, child);
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x0000448C File Offset: 0x0000268C
		public void RemoveChild(YogaNode child)
		{
			int num = this.IndexOf(child);
			bool flag = num >= 0;
			if (flag)
			{
				this.RemoveAt(num);
			}
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x000044B8 File Offset: 0x000026B8
		public void Clear()
		{
			bool flag = this._children != null;
			if (flag)
			{
				while (this._children.Count > 0)
				{
					this.RemoveAt(this._children.Count - 1);
				}
			}
		}

		// Token: 0x060000DA RID: 218 RVA: 0x00004500 File Offset: 0x00002700
		public int IndexOf(YogaNode node)
		{
			return (this._children != null) ? this._children.IndexOf(node) : (-1);
		}

		// Token: 0x060000DB RID: 219 RVA: 0x0000452C File Offset: 0x0000272C
		public void SetMeasureFunction(MeasureFunction measureFunction)
		{
			this._measureFunction = measureFunction;
			bool flag = measureFunction == null;
			if (flag)
			{
				bool flag2 = !this.IsBaselineDefined;
				if (flag2)
				{
					Native.YGSetManagedObject(this._ygNode, null);
				}
				Native.YGNodeRemoveMeasureFunc(this._ygNode);
			}
			else
			{
				Native.YGSetManagedObject(this._ygNode, this);
				Native.YGNodeSetMeasureFunc(this._ygNode);
			}
		}

		// Token: 0x060000DC RID: 220 RVA: 0x00004590 File Offset: 0x00002790
		public void SetBaselineFunction(BaselineFunction baselineFunction)
		{
			this._baselineFunction = baselineFunction;
			bool flag = baselineFunction == null;
			if (flag)
			{
				bool flag2 = !this.IsMeasureDefined;
				if (flag2)
				{
					Native.YGSetManagedObject(this._ygNode, null);
				}
				Native.YGNodeRemoveBaselineFunc(this._ygNode);
			}
			else
			{
				Native.YGSetManagedObject(this._ygNode, this);
				Native.YGNodeSetBaselineFunc(this._ygNode);
			}
		}

		// Token: 0x060000DD RID: 221 RVA: 0x0000288C File Offset: 0x00000A8C
		public void CalculateLayout([Optional] float width, [Optional] float height)
		{
			Native.YGNodeCalculateLayout(this._ygNode, width, height, Native.YGNodeStyleGetDirection(this._ygNode));
		}

		// Token: 0x060000DE RID: 222 RVA: 0x000028A8 File Offset: 0x00000AA8
		public string Print([Optional] YogaPrintOptions options)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060000DF RID: 223 RVA: 0x000045F4 File Offset: 0x000027F4
		public static int GetInstanceCount()
		{
			return Native.YGNodeGetInstanceCount();
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060000E0 RID: 224 RVA: 0x0000460C File Offset: 0x0000280C
		// (set) Token: 0x060000E1 RID: 225 RVA: 0x000028B5 File Offset: 0x00000AB5
		public float BorderLeftWidth
		{
			get
			{
				return Native.YGNodeStyleGetBorder(this._ygNode, YogaEdge.Left);
			}
			set
			{
				Native.YGNodeStyleSetBorder(this._ygNode, YogaEdge.Left, value);
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060000E2 RID: 226 RVA: 0x0000462C File Offset: 0x0000282C
		// (set) Token: 0x060000E3 RID: 227 RVA: 0x000028C6 File Offset: 0x00000AC6
		public float BorderTopWidth
		{
			get
			{
				return Native.YGNodeStyleGetBorder(this._ygNode, YogaEdge.Top);
			}
			set
			{
				Native.YGNodeStyleSetBorder(this._ygNode, YogaEdge.Top, value);
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060000E4 RID: 228 RVA: 0x0000464C File Offset: 0x0000284C
		// (set) Token: 0x060000E5 RID: 229 RVA: 0x000028D7 File Offset: 0x00000AD7
		public float BorderRightWidth
		{
			get
			{
				return Native.YGNodeStyleGetBorder(this._ygNode, YogaEdge.Right);
			}
			set
			{
				Native.YGNodeStyleSetBorder(this._ygNode, YogaEdge.Right, value);
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060000E6 RID: 230 RVA: 0x0000466C File Offset: 0x0000286C
		// (set) Token: 0x060000E7 RID: 231 RVA: 0x000028E8 File Offset: 0x00000AE8
		public float BorderBottomWidth
		{
			get
			{
				return Native.YGNodeStyleGetBorder(this._ygNode, YogaEdge.Bottom);
			}
			set
			{
				Native.YGNodeStyleSetBorder(this._ygNode, YogaEdge.Bottom, value);
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060000E8 RID: 232 RVA: 0x0000468C File Offset: 0x0000288C
		// (set) Token: 0x060000E9 RID: 233 RVA: 0x000028F9 File Offset: 0x00000AF9
		public float BorderStartWidth
		{
			get
			{
				return Native.YGNodeStyleGetBorder(this._ygNode, YogaEdge.Start);
			}
			set
			{
				Native.YGNodeStyleSetBorder(this._ygNode, YogaEdge.Start, value);
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060000EA RID: 234 RVA: 0x000046AC File Offset: 0x000028AC
		// (set) Token: 0x060000EB RID: 235 RVA: 0x0000290A File Offset: 0x00000B0A
		public float BorderEndWidth
		{
			get
			{
				return Native.YGNodeStyleGetBorder(this._ygNode, YogaEdge.End);
			}
			set
			{
				Native.YGNodeStyleSetBorder(this._ygNode, YogaEdge.End, value);
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060000EC RID: 236 RVA: 0x000046CC File Offset: 0x000028CC
		// (set) Token: 0x060000ED RID: 237 RVA: 0x0000291B File Offset: 0x00000B1B
		public float BorderWidth
		{
			get
			{
				return Native.YGNodeStyleGetBorder(this._ygNode, YogaEdge.All);
			}
			set
			{
				Native.YGNodeStyleSetBorder(this._ygNode, YogaEdge.All, value);
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060000EE RID: 238 RVA: 0x000046EC File Offset: 0x000028EC
		public float LayoutMarginLeft
		{
			get
			{
				return Native.YGNodeLayoutGetMargin(this._ygNode, YogaEdge.Left);
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060000EF RID: 239 RVA: 0x0000470C File Offset: 0x0000290C
		public float LayoutMarginTop
		{
			get
			{
				return Native.YGNodeLayoutGetMargin(this._ygNode, YogaEdge.Top);
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060000F0 RID: 240 RVA: 0x0000472C File Offset: 0x0000292C
		public float LayoutMarginRight
		{
			get
			{
				return Native.YGNodeLayoutGetMargin(this._ygNode, YogaEdge.Right);
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060000F1 RID: 241 RVA: 0x0000474C File Offset: 0x0000294C
		public float LayoutMarginBottom
		{
			get
			{
				return Native.YGNodeLayoutGetMargin(this._ygNode, YogaEdge.Bottom);
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060000F2 RID: 242 RVA: 0x0000476C File Offset: 0x0000296C
		public float LayoutMarginStart
		{
			get
			{
				return Native.YGNodeLayoutGetMargin(this._ygNode, YogaEdge.Start);
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060000F3 RID: 243 RVA: 0x0000478C File Offset: 0x0000298C
		public float LayoutMarginEnd
		{
			get
			{
				return Native.YGNodeLayoutGetMargin(this._ygNode, YogaEdge.End);
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060000F4 RID: 244 RVA: 0x000047AC File Offset: 0x000029AC
		public float LayoutPaddingLeft
		{
			get
			{
				return Native.YGNodeLayoutGetPadding(this._ygNode, YogaEdge.Left);
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060000F5 RID: 245 RVA: 0x000047CC File Offset: 0x000029CC
		public float LayoutPaddingTop
		{
			get
			{
				return Native.YGNodeLayoutGetPadding(this._ygNode, YogaEdge.Top);
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060000F6 RID: 246 RVA: 0x000047EC File Offset: 0x000029EC
		public float LayoutPaddingRight
		{
			get
			{
				return Native.YGNodeLayoutGetPadding(this._ygNode, YogaEdge.Right);
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060000F7 RID: 247 RVA: 0x0000480C File Offset: 0x00002A0C
		public float LayoutPaddingBottom
		{
			get
			{
				return Native.YGNodeLayoutGetPadding(this._ygNode, YogaEdge.Bottom);
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060000F8 RID: 248 RVA: 0x0000482C File Offset: 0x00002A2C
		public float LayoutPaddingStart
		{
			get
			{
				return Native.YGNodeLayoutGetPadding(this._ygNode, YogaEdge.Start);
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x060000F9 RID: 249 RVA: 0x0000484C File Offset: 0x00002A4C
		public float LayoutPaddingEnd
		{
			get
			{
				return Native.YGNodeLayoutGetPadding(this._ygNode, YogaEdge.End);
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x060000FA RID: 250 RVA: 0x0000486C File Offset: 0x00002A6C
		public float ComputedFlexBasis
		{
			get
			{
				return Native.YGNodeGetComputedFlexBasis(this._ygNode);
			}
		}

		// Token: 0x04000078 RID: 120
		private static readonly IntPtr NativeFieldInfoPtr__ygNode;

		// Token: 0x04000079 RID: 121
		private static readonly IntPtr NativeFieldInfoPtr__config;

		// Token: 0x0400007A RID: 122
		private static readonly IntPtr NativeFieldInfoPtr__parent;

		// Token: 0x0400007B RID: 123
		private static readonly IntPtr NativeFieldInfoPtr__children;

		// Token: 0x0400007C RID: 124
		private static readonly IntPtr NativeFieldInfoPtr__measureFunction;

		// Token: 0x0400007D RID: 125
		private static readonly IntPtr NativeFieldInfoPtr__baselineFunction;

		// Token: 0x0400007E RID: 126
		private static readonly IntPtr NativeFieldInfoPtr__data;

		// Token: 0x0400007F RID: 127
		private static readonly IntPtr NativeMethodInfoPtr_get_LayoutX_Public_get_Single_0;

		// Token: 0x04000080 RID: 128
		private static readonly IntPtr NativeMethodInfoPtr_get_LayoutY_Public_get_Single_0;

		// Token: 0x04000081 RID: 129
		private static readonly IntPtr NativeMethodInfoPtr_get_LayoutWidth_Public_get_Single_0;

		// Token: 0x04000082 RID: 130
		private static readonly IntPtr NativeMethodInfoPtr_get_LayoutHeight_Public_get_Single_0;

		// Token: 0x04000083 RID: 131
		private static readonly IntPtr NativeMethodInfoPtr_MeasureInternal_Public_Static_YogaSize_YogaNode_Single_YogaMeasureMode_Single_YogaMeasureMode_0;

		// Token: 0x04000084 RID: 132
		private static readonly IntPtr NativeMethodInfoPtr_BaselineInternal_Public_Static_Single_YogaNode_Single_Single_0;

		// Token: 0x04000085 RID: 133
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_YogaNode_0;

		// Token: 0x04000086 RID: 134
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

		// Token: 0x02000078 RID: 120
		public sealed class <>c__DisplayClass123_0
		{
		}
	}
}
