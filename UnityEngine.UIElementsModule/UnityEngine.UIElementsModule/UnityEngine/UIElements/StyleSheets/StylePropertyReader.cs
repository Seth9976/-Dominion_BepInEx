using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.UIElements.StyleSheets
{
	// Token: 0x020000E5 RID: 229
	public class StylePropertyReader : Object
	{
		// Token: 0x06000CAC RID: 3244 RVA: 0x00032D6C File Offset: 0x00030F6C
		// Note: this type is marked as 'beforefieldinit'.
		static StylePropertyReader()
		{
			Il2CppClassPointerStore<StylePropertyReader>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements.StyleSheets", "StylePropertyReader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StylePropertyReader>.NativeClassPtr);
			StylePropertyReader.NativeFieldInfoPtr_getCursorIdFunc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StylePropertyReader>.NativeClassPtr, "getCursorIdFunc");
			StylePropertyReader.NativeFieldInfoPtr_m_Values = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StylePropertyReader>.NativeClassPtr, "m_Values");
			StylePropertyReader.NativeFieldInfoPtr_m_ValueCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StylePropertyReader>.NativeClassPtr, "m_ValueCount");
			StylePropertyReader.NativeFieldInfoPtr_m_Resolver = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StylePropertyReader>.NativeClassPtr, "m_Resolver");
			StylePropertyReader.NativeFieldInfoPtr_m_Sheet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StylePropertyReader>.NativeClassPtr, "m_Sheet");
			StylePropertyReader.NativeFieldInfoPtr_m_Properties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StylePropertyReader>.NativeClassPtr, "m_Properties");
			StylePropertyReader.NativeFieldInfoPtr_m_PropertyIds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StylePropertyReader>.NativeClassPtr, "m_PropertyIds");
			StylePropertyReader.NativeFieldInfoPtr_m_CurrentValueIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StylePropertyReader>.NativeClassPtr, "m_CurrentValueIndex");
			StylePropertyReader.NativeFieldInfoPtr_m_CurrentPropertyIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StylePropertyReader>.NativeClassPtr, "m_CurrentPropertyIndex");
			StylePropertyReader.NativeFieldInfoPtr__property_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StylePropertyReader>.NativeClassPtr, "<property>k__BackingField");
			StylePropertyReader.NativeFieldInfoPtr__propertyId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StylePropertyReader>.NativeClassPtr, "<propertyId>k__BackingField");
			StylePropertyReader.NativeFieldInfoPtr__valueCount_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StylePropertyReader>.NativeClassPtr, "<valueCount>k__BackingField");
			StylePropertyReader.NativeFieldInfoPtr__dpiScaling_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StylePropertyReader>.NativeClassPtr, "<dpiScaling>k__BackingField");
			StylePropertyReader.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyReader>.NativeClassPtr, 100664279);
		}

		// Token: 0x06000CAD RID: 3245 RVA: 0x00032EB4 File Offset: 0x000310B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97303, XrefRangeEnd = 97336, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StylePropertyReader()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StylePropertyReader>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyReader.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CAE RID: 3246 RVA: 0x00008061 File Offset: 0x00006261
		public StylePropertyReader(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000437 RID: 1079
		// (get) Token: 0x06000CAF RID: 3247 RVA: 0x00032EF0 File Offset: 0x000310F0
		// (set) Token: 0x06000CB0 RID: 3248 RVA: 0x0000806A File Offset: 0x0000626A
		public unsafe static StylePropertyReader.GetCursorIdFunction getCursorIdFunc
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(StylePropertyReader.NativeFieldInfoPtr_getCursorIdFunc, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StylePropertyReader.GetCursorIdFunction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StylePropertyReader.NativeFieldInfoPtr_getCursorIdFunc, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000438 RID: 1080
		// (get) Token: 0x06000CB1 RID: 3249 RVA: 0x00032F18 File Offset: 0x00031118
		// (set) Token: 0x06000CB2 RID: 3250 RVA: 0x0000807C File Offset: 0x0000627C
		public unsafe List<StylePropertyValue> m_Values
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StylePropertyReader.NativeFieldInfoPtr_m_Values);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<StylePropertyValue>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StylePropertyReader.NativeFieldInfoPtr_m_Values), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000439 RID: 1081
		// (get) Token: 0x06000CB3 RID: 3251 RVA: 0x00032F48 File Offset: 0x00031148
		// (set) Token: 0x06000CB4 RID: 3252 RVA: 0x0000809B File Offset: 0x0000629B
		public unsafe List<int> m_ValueCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StylePropertyReader.NativeFieldInfoPtr_m_ValueCount);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StylePropertyReader.NativeFieldInfoPtr_m_ValueCount), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700043A RID: 1082
		// (get) Token: 0x06000CB5 RID: 3253 RVA: 0x00032F78 File Offset: 0x00031178
		// (set) Token: 0x06000CB6 RID: 3254 RVA: 0x000080BA File Offset: 0x000062BA
		public unsafe StyleVariableResolver m_Resolver
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StylePropertyReader.NativeFieldInfoPtr_m_Resolver);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StyleVariableResolver>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StylePropertyReader.NativeFieldInfoPtr_m_Resolver), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700043B RID: 1083
		// (get) Token: 0x06000CB7 RID: 3255 RVA: 0x00032FA8 File Offset: 0x000311A8
		// (set) Token: 0x06000CB8 RID: 3256 RVA: 0x000080D9 File Offset: 0x000062D9
		public unsafe StyleSheet m_Sheet
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StylePropertyReader.NativeFieldInfoPtr_m_Sheet);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StyleSheet>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StylePropertyReader.NativeFieldInfoPtr_m_Sheet), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700043C RID: 1084
		// (get) Token: 0x06000CB9 RID: 3257 RVA: 0x00032FD8 File Offset: 0x000311D8
		// (set) Token: 0x06000CBA RID: 3258 RVA: 0x000080F8 File Offset: 0x000062F8
		public unsafe Il2CppReferenceArray<StyleProperty> m_Properties
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StylePropertyReader.NativeFieldInfoPtr_m_Properties);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<StyleProperty>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StylePropertyReader.NativeFieldInfoPtr_m_Properties), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700043D RID: 1085
		// (get) Token: 0x06000CBB RID: 3259 RVA: 0x00033008 File Offset: 0x00031208
		// (set) Token: 0x06000CBC RID: 3260 RVA: 0x00008117 File Offset: 0x00006317
		public unsafe Il2CppStructArray<StylePropertyId> m_PropertyIds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StylePropertyReader.NativeFieldInfoPtr_m_PropertyIds);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<StylePropertyId>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StylePropertyReader.NativeFieldInfoPtr_m_PropertyIds), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700043E RID: 1086
		// (get) Token: 0x06000CBD RID: 3261 RVA: 0x00033038 File Offset: 0x00031238
		// (set) Token: 0x06000CBE RID: 3262 RVA: 0x00008136 File Offset: 0x00006336
		public unsafe int m_CurrentValueIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StylePropertyReader.NativeFieldInfoPtr_m_CurrentValueIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StylePropertyReader.NativeFieldInfoPtr_m_CurrentValueIndex)) = value;
			}
		}

		// Token: 0x1700043F RID: 1087
		// (get) Token: 0x06000CBF RID: 3263 RVA: 0x00033060 File Offset: 0x00031260
		// (set) Token: 0x06000CC0 RID: 3264 RVA: 0x00008151 File Offset: 0x00006351
		public unsafe int m_CurrentPropertyIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StylePropertyReader.NativeFieldInfoPtr_m_CurrentPropertyIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StylePropertyReader.NativeFieldInfoPtr_m_CurrentPropertyIndex)) = value;
			}
		}

		// Token: 0x17000440 RID: 1088
		// (get) Token: 0x06000CC1 RID: 3265 RVA: 0x00033088 File Offset: 0x00031288
		// (set) Token: 0x06000CC2 RID: 3266 RVA: 0x0000816C File Offset: 0x0000636C
		public unsafe StyleProperty _property_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StylePropertyReader.NativeFieldInfoPtr__property_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StyleProperty>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StylePropertyReader.NativeFieldInfoPtr__property_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000441 RID: 1089
		// (get) Token: 0x06000CC3 RID: 3267 RVA: 0x000330B8 File Offset: 0x000312B8
		// (set) Token: 0x06000CC4 RID: 3268 RVA: 0x0000818B File Offset: 0x0000638B
		public unsafe StylePropertyId _propertyId_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StylePropertyReader.NativeFieldInfoPtr__propertyId_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StylePropertyReader.NativeFieldInfoPtr__propertyId_k__BackingField)) = value;
			}
		}

		// Token: 0x17000442 RID: 1090
		// (get) Token: 0x06000CC5 RID: 3269 RVA: 0x000330E0 File Offset: 0x000312E0
		// (set) Token: 0x06000CC6 RID: 3270 RVA: 0x000081A6 File Offset: 0x000063A6
		public unsafe int _valueCount_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StylePropertyReader.NativeFieldInfoPtr__valueCount_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StylePropertyReader.NativeFieldInfoPtr__valueCount_k__BackingField)) = value;
			}
		}

		// Token: 0x17000443 RID: 1091
		// (get) Token: 0x06000CC7 RID: 3271 RVA: 0x00033108 File Offset: 0x00031308
		// (set) Token: 0x06000CC8 RID: 3272 RVA: 0x000081C1 File Offset: 0x000063C1
		public unsafe float _dpiScaling_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StylePropertyReader.NativeFieldInfoPtr__dpiScaling_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StylePropertyReader.NativeFieldInfoPtr__dpiScaling_k__BackingField)) = value;
			}
		}

		// Token: 0x17000444 RID: 1092
		// (get) Token: 0x06000CC9 RID: 3273 RVA: 0x000081DC File Offset: 0x000063DC
		// (set) Token: 0x06000CCA RID: 3274 RVA: 0x000081E4 File Offset: 0x000063E4
		public StyleProperty property
		{
			get
			{
				return this._property_k__BackingField;
			}
			set
			{
				this._property_k__BackingField = value;
			}
		}

		// Token: 0x17000445 RID: 1093
		// (get) Token: 0x06000CCB RID: 3275 RVA: 0x000081ED File Offset: 0x000063ED
		// (set) Token: 0x06000CCC RID: 3276 RVA: 0x000081F5 File Offset: 0x000063F5
		public StylePropertyId propertyId
		{
			get
			{
				return this._propertyId_k__BackingField;
			}
			set
			{
				this._propertyId_k__BackingField = value;
			}
		}

		// Token: 0x17000446 RID: 1094
		// (get) Token: 0x06000CCD RID: 3277 RVA: 0x000081FE File Offset: 0x000063FE
		// (set) Token: 0x06000CCE RID: 3278 RVA: 0x00008206 File Offset: 0x00006406
		public int valueCount
		{
			get
			{
				return this._valueCount_k__BackingField;
			}
			set
			{
				this._valueCount_k__BackingField = value;
			}
		}

		// Token: 0x17000447 RID: 1095
		// (get) Token: 0x06000CCF RID: 3279 RVA: 0x0000820F File Offset: 0x0000640F
		// (set) Token: 0x06000CD0 RID: 3280 RVA: 0x00008217 File Offset: 0x00006417
		public float dpiScaling
		{
			get
			{
				return this._dpiScaling_k__BackingField;
			}
			set
			{
				this._dpiScaling_k__BackingField = value;
			}
		}

		// Token: 0x06000CD1 RID: 3281 RVA: 0x00033130 File Offset: 0x00031330
		public void SetContext(StyleSheet sheet, StyleComplexSelector selector, StyleVariableContext varContext, [Optional] float dpiScaling)
		{
			this.m_Sheet = sheet;
			this.m_Properties = selector.rule.properties;
			this.m_PropertyIds = StyleSheetCache.GetPropertyIds(sheet, selector.ruleIndex);
			this.m_Resolver.variableContext = varContext;
			this.dpiScaling = dpiScaling;
			this.LoadProperties();
		}

		// Token: 0x06000CD2 RID: 3282 RVA: 0x00008220 File Offset: 0x00006420
		public void SetInlineContext(StyleSheet sheet, Il2CppReferenceArray<StyleProperty> properties, Il2CppStructArray<StylePropertyId> propertyIds, [Optional] float dpiScaling)
		{
			this.m_Sheet = sheet;
			this.m_Properties = properties;
			this.m_PropertyIds = propertyIds;
			this.dpiScaling = dpiScaling;
			this.LoadProperties();
		}

		// Token: 0x06000CD3 RID: 3283 RVA: 0x00033188 File Offset: 0x00031388
		public StylePropertyId MoveNextProperty()
		{
			this.m_CurrentPropertyIndex++;
			this.m_CurrentValueIndex += this.valueCount;
			this.SetCurrentProperty();
			return this.propertyId;
		}

		// Token: 0x06000CD4 RID: 3284 RVA: 0x000331C8 File Offset: 0x000313C8
		public StylePropertyValue GetValue(int index)
		{
			return this.m_Values[this.m_CurrentValueIndex + index];
		}

		// Token: 0x06000CD5 RID: 3285 RVA: 0x00008248 File Offset: 0x00006448
		public StyleValueType GetValueType(int index)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000CD6 RID: 3286 RVA: 0x00008255 File Offset: 0x00006455
		public bool IsValueType(int index, StyleValueType type)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000CD7 RID: 3287 RVA: 0x00008262 File Offset: 0x00006462
		public bool IsKeyword(int index, StyleValueKeyword keyword)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000CD8 RID: 3288 RVA: 0x000331F0 File Offset: 0x000313F0
		public string ReadAsString(int index)
		{
			StylePropertyValue stylePropertyValue = this.m_Values[this.m_CurrentValueIndex + index];
			return StyleSheetExtensions.ReadAsString(stylePropertyValue.sheet, stylePropertyValue.handle);
		}

		// Token: 0x06000CD9 RID: 3289 RVA: 0x0000826F File Offset: 0x0000646F
		public Length ReadLength(int index)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000CDA RID: 3290 RVA: 0x00033228 File Offset: 0x00031428
		public float ReadFloat(int index)
		{
			StylePropertyValue stylePropertyValue = this.m_Values[this.m_CurrentValueIndex + index];
			return stylePropertyValue.sheet.ReadFloat(stylePropertyValue.handle);
		}

		// Token: 0x06000CDB RID: 3291 RVA: 0x00033260 File Offset: 0x00031460
		public int ReadInt(int index)
		{
			StylePropertyValue stylePropertyValue = this.m_Values[this.m_CurrentValueIndex + index];
			return (int)stylePropertyValue.sheet.ReadFloat(stylePropertyValue.handle);
		}

		// Token: 0x06000CDC RID: 3292 RVA: 0x0000827C File Offset: 0x0000647C
		public Color ReadColor(int index)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000CDD RID: 3293 RVA: 0x00033298 File Offset: 0x00031498
		public int ReadEnum(StyleEnumType enumType, int index)
		{
			StylePropertyValue stylePropertyValue = this.m_Values[this.m_CurrentValueIndex + index];
			StyleValueHandle handle = stylePropertyValue.handle;
			bool flag = handle.valueType == StyleValueType.Keyword;
			string text;
			if (flag)
			{
				StyleValueKeyword styleValueKeyword = stylePropertyValue.sheet.ReadKeyword(handle);
				text = StyleValueKeywordExtension.ToUssString(styleValueKeyword);
			}
			else
			{
				text = stylePropertyValue.sheet.ReadEnum(handle);
			}
			return StylePropertyUtil.GetEnumIntValue(enumType, text);
		}

		// Token: 0x06000CDE RID: 3294 RVA: 0x00008289 File Offset: 0x00006489
		public Font ReadFont(int index)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000CDF RID: 3295 RVA: 0x00008296 File Offset: 0x00006496
		public Background ReadBackground(int index)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000CE0 RID: 3296 RVA: 0x000082A3 File Offset: 0x000064A3
		public Cursor ReadCursor(int index)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000CE1 RID: 3297 RVA: 0x00033308 File Offset: 0x00031508
		public TextShadow ReadTextShadow(int index)
		{
			float num = 0f;
			float num2 = 0f;
			float num3 = 0f;
			Color color = Color.clear;
			bool flag = this.valueCount >= 2;
			if (flag)
			{
				int num4 = index;
				StyleValueType styleValueType = this.GetValueType(num4);
				bool flag2 = false;
				bool flag3 = styleValueType == StyleValueType.Color || styleValueType == StyleValueType.Enum;
				if (flag3)
				{
					color = this.ReadColor(num4++);
					flag2 = true;
				}
				bool flag4 = num4 + 1 < this.valueCount;
				if (flag4)
				{
					styleValueType = this.GetValueType(num4);
					StyleValueType valueType = this.GetValueType(num4 + 1);
					bool flag5 = styleValueType == StyleValueType.Dimension && valueType == StyleValueType.Dimension;
					if (flag5)
					{
						StylePropertyValue value = this.GetValue(num4++);
						StylePropertyValue value2 = this.GetValue(num4++);
						num = value.sheet.ReadDimension(value.handle).value;
						num2 = value2.sheet.ReadDimension(value2.handle).value;
					}
				}
				bool flag6 = num4 < this.valueCount;
				if (flag6)
				{
					styleValueType = this.GetValueType(num4);
					bool flag7 = styleValueType == StyleValueType.Dimension;
					if (flag7)
					{
						StylePropertyValue value3 = this.GetValue(num4++);
						num3 = value3.sheet.ReadDimension(value3.handle).value;
					}
					else
					{
						bool flag8 = styleValueType == StyleValueType.Color || styleValueType == StyleValueType.Enum;
						if (flag8)
						{
							bool flag9 = !flag2;
							if (flag9)
							{
								color = this.ReadColor(num4);
							}
						}
					}
				}
				bool flag10 = num4 < this.valueCount;
				if (flag10)
				{
					styleValueType = this.GetValueType(num4);
					bool flag11 = styleValueType == StyleValueType.Color || styleValueType == StyleValueType.Enum;
					if (flag11)
					{
						bool flag12 = !flag2;
						if (flag12)
						{
							color = this.ReadColor(num4);
						}
					}
				}
			}
			return new TextShadow
			{
				offset = new Vector2(num, num2),
				blurRadius = num3,
				color = color
			};
		}

		// Token: 0x06000CE2 RID: 3298 RVA: 0x000082B0 File Offset: 0x000064B0
		public void LoadProperties()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000CE3 RID: 3299 RVA: 0x000082BD File Offset: 0x000064BD
		public void SetCurrentProperty()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0400072A RID: 1834
		private static readonly IntPtr NativeFieldInfoPtr_getCursorIdFunc;

		// Token: 0x0400072B RID: 1835
		private static readonly IntPtr NativeFieldInfoPtr_m_Values;

		// Token: 0x0400072C RID: 1836
		private static readonly IntPtr NativeFieldInfoPtr_m_ValueCount;

		// Token: 0x0400072D RID: 1837
		private static readonly IntPtr NativeFieldInfoPtr_m_Resolver;

		// Token: 0x0400072E RID: 1838
		private static readonly IntPtr NativeFieldInfoPtr_m_Sheet;

		// Token: 0x0400072F RID: 1839
		private static readonly IntPtr NativeFieldInfoPtr_m_Properties;

		// Token: 0x04000730 RID: 1840
		private static readonly IntPtr NativeFieldInfoPtr_m_PropertyIds;

		// Token: 0x04000731 RID: 1841
		private static readonly IntPtr NativeFieldInfoPtr_m_CurrentValueIndex;

		// Token: 0x04000732 RID: 1842
		private static readonly IntPtr NativeFieldInfoPtr_m_CurrentPropertyIndex;

		// Token: 0x04000733 RID: 1843
		private static readonly IntPtr NativeFieldInfoPtr__property_k__BackingField;

		// Token: 0x04000734 RID: 1844
		private static readonly IntPtr NativeFieldInfoPtr__propertyId_k__BackingField;

		// Token: 0x04000735 RID: 1845
		private static readonly IntPtr NativeFieldInfoPtr__valueCount_k__BackingField;

		// Token: 0x04000736 RID: 1846
		private static readonly IntPtr NativeFieldInfoPtr__dpiScaling_k__BackingField;

		// Token: 0x04000737 RID: 1847
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200022E RID: 558
		public sealed class GetCursorIdFunction : MulticastDelegate
		{
			// Token: 0x06001404 RID: 5124 RVA: 0x0000CD62 File Offset: 0x0000AF62
			// Note: this type is marked as 'beforefieldinit'.
			static GetCursorIdFunction()
			{
				Il2CppClassPointerStore<StylePropertyReader.GetCursorIdFunction>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StylePropertyReader>.NativeClassPtr, "GetCursorIdFunction");
				StylePropertyReader.GetCursorIdFunction.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyReader.GetCursorIdFunction>.NativeClassPtr, 100664281);
				StylePropertyReader.GetCursorIdFunction.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Int32_StyleSheet_StyleValueHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyReader.GetCursorIdFunction>.NativeClassPtr, 100664282);
			}

			// Token: 0x06001405 RID: 5125 RVA: 0x0003D124 File Offset: 0x0003B324
			[CallerCount(1135)]
			[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe GetCursorIdFunction(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StylePropertyReader.GetCursorIdFunction>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyReader.GetCursorIdFunction.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001406 RID: 5126 RVA: 0x0003D180 File Offset: 0x0003B380
			[CallerCount(0)]
			public unsafe int Invoke(StyleSheet sheet, StyleValueHandle handle)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(sheet);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyReader.GetCursorIdFunction.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Int32_StyleSheet_StyleValueHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06001407 RID: 5127 RVA: 0x0000CDA0 File Offset: 0x0000AFA0
			public GetCursorIdFunction(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001408 RID: 5128 RVA: 0x0000CDA9 File Offset: 0x0000AFA9
			public static implicit operator StylePropertyReader.GetCursorIdFunction(Func<StyleSheet, StyleValueHandle, int> A_0)
			{
				return DelegateSupport.ConvertDelegate<StylePropertyReader.GetCursorIdFunction>(A_0);
			}

			// Token: 0x06001409 RID: 5129 RVA: 0x0000CDB1 File Offset: 0x0000AFB1
			public static StylePropertyReader.GetCursorIdFunction operator +(StylePropertyReader.GetCursorIdFunction A_0, StylePropertyReader.GetCursorIdFunction A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<StylePropertyReader.GetCursorIdFunction>();
			}

			// Token: 0x0600140A RID: 5130 RVA: 0x0000CDBF File Offset: 0x0000AFBF
			public static StylePropertyReader.GetCursorIdFunction operator -(StylePropertyReader.GetCursorIdFunction A_0, StylePropertyReader.GetCursorIdFunction A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<StylePropertyReader.GetCursorIdFunction>();
				}
				return delegate2;
			}

			// Token: 0x04000908 RID: 2312
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04000909 RID: 2313
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Int32_StyleSheet_StyleValueHandle_0;
		}
	}
}
